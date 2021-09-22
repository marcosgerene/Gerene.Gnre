using OpenAC.Net.Core;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core;
using OpenAC.Net.DFe.Core.Service;
using Gerene.Gnre.Classes;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Gerene.Gnre.WebService
{
    //Baseado em https://github.com/OpenACNet/OpenAC.Net.NFSe/blob/master/src/OpenAC.Net.NFSe/Providers/NFSeServiceClient.cs
    public abstract class WebServiceClient : DFeServiceClientBase<IRequestChannel>
    {
        protected readonly object serviceLock = new object();

        public string XmlEnvio { get; private set; }
        public string XmlResposta { get; private set; }
        public string EnvelopeEnvio { get; protected set; }
        public string EnvelopeRetorno { get; protected set; }

        protected string PrefixoEnvio { get; set; }
        protected string PrefixoResposta { get; set; }
        public ConfiguracaoWebService Configuracao { get; set; }

        protected WebServiceClient(string url, ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(url, TimeSpan.FromMilliseconds(configuracao.Timeout), certificado)
        {
            Configuracao = configuracao;

            (Endpoint.Binding as BasicHttpBinding).MaxReceivedMessageSize = int.MaxValue; //alguns métodos como buscarServios tem retornos muito grande
            var custom = new CustomBinding(Endpoint.Binding);

            var version = custom.Elements.Find<TextMessageEncodingBindingElement>();
            version.MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None);
            
            Endpoint.Binding = custom;            
        }

        private Message WriteSoapEnvelope(string message, string _namespace, VersaoDados versao, string soapAction)
        {
            var envelope = new StringBuilder();
            envelope.Append($"<soap:Envelope xmlns:soap=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:gnr=\"{_namespace}\">");
            envelope.Append("<soap:Header>");
            envelope.Append($"<gnr:gnreCabecMsg><gnr:versaoDados>{(versao == VersaoDados.Versao1 ? "1.00" : "2.00")}</gnr:versaoDados></gnr:gnreCabecMsg>");
            envelope.Append("</soap:Header>");
            envelope.Append("<soap:Body>");
            envelope.Append("<gnr:gnreDadosMsg>");
            envelope.Append(message);
            envelope.Append("</gnr:gnreDadosMsg>");
            envelope.Append("</soap:Body>");
            envelope.Append("</soap:Envelope>");

            var request = Message.CreateMessage(XmlReader.Create(new StringReader(envelope.ToString())), int.MaxValue, Endpoint.Binding.MessageVersion);

            //Define a action no content type por ser SOAP 1.2
            var requestMessage = new HttpRequestMessageProperty();
            requestMessage.Headers["Content-Type"] = $"application/soap+xml;charset=UTF-8;action=\"{soapAction}\"";

            request.Properties[HttpRequestMessageProperty.Name] = requestMessage;

            return request;
        }

        protected string Executar(string message, string _namespace, VersaoDados versao, string soapAction)
        {
            XmlEnvio = message;

            if (Configuracao.SalvarXmls)
                GravarXml(XmlEnvio, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoEnvio}_env.xml");

            var request = WriteSoapEnvelope(message, _namespace, versao, soapAction);

            RemoteCertificateValidationCallback validation = null;
            if (!Configuracao.ValidarCertificado)
            {
                validation = ServicePointManager.ServerCertificateValidationCallback;
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            }

            string soapResponse;

            try
            {
                lock (serviceLock)
                {
                    var response = Channel.Request(request);
                    Guard.Against<OpenDFeException>(response == null, "Nenhum retorno do webservice.");
                    var reader = response.GetReaderAtBodyContents();
                    soapResponse = reader.ReadOuterXml();
                }
            }
            finally
            {
                if (Configuracao.ValidarCertificado)
                    ServicePointManager.ServerCertificateValidationCallback = validation;
            }

            var xmlDocument = XDocument.Parse(soapResponse);
            var retorno = TratarRetorno(xmlDocument);
            if (retorno.IsValidXml())
            {
                if (Configuracao.SalvarXmls)
                {
                    XmlResposta = retorno;
                    GravarXml(XmlResposta, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoEnvio}_ret.xml");
                }

                return retorno;
            }

            throw new ApplicationException(retorno);
        }

        protected string TratarRetorno(XDocument xmlDocument)
        {
            var element = xmlDocument.ElementAnyNs("Fault");
            if (element != null)
            {
                var exMessage = $"{element.ElementAnyNs("Code")?.ElementAnyNs("Value")?.GetValue<string>()} - " +
                                $"{element.ElementAnyNs("Reason")?.ElementAnyNs("Text")?.GetValue<string>()}";
                throw new OpenDFeCommunicationException(exMessage);
            }

            return xmlDocument.ToXmlDocument().OuterXml;
        }


        /// <summary>
        /// Salvar o arquivo xml no disco de acordo com as propriedades.
        /// </summary>
        /// <param name="conteudoArquivo"></param>
        /// <param name="nomeArquivo"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected virtual void GravarXml(string conteudoArquivo, string nomeArquivo)
        {            
            string path = Path.Combine(Configuracao.DiretorioXmls, nomeArquivo);
            File.WriteAllText(path, conteudoArquivo, Encoding.UTF8);
        }

        protected override void BeforeSendDFeRequest(string message)
        {
            EnvelopeEnvio = message;

            if (Configuracao.SalvarSoap)
                GravarXml(EnvelopeEnvio, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoEnvio}_soap_env.xml");
        }

        protected override void AfterReceiveDFeReply(string message)
        {
            EnvelopeRetorno = message;

            if (Configuracao.SalvarSoap)
                GravarXml(EnvelopeRetorno, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoResposta}_soap_ret.xml");
        }

    }
}
