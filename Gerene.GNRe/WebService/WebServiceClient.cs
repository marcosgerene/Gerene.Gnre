using ACBr.Net.Core;
using ACBr.Net.DFe.Core;
using ACBr.Net.DFe.Core.Service;

using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Gerene.GNRe.WebService
{
    //Baseado em https://github.com/ACBrNet/ACBr.Net.NFSe/blob/master/src/ACBr.Net.NFSe/Providers/NFSeServiceClient.cs
    public abstract class WebServiceClient : DFeServiceClientBase<IRequestChannel>
    {
        protected readonly object serviceLock;

        protected string EnvelopeEnvio { get; set; }
        protected string EnvelopeRetorno { get; set; }
        protected string PrefixoEnvio { get; set; }
        protected string PrefixoResposta { get; set; }
        public ConfiguracaoWebService Configuracao { get; set; }

        protected WebServiceClient(string url, ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(url, TimeSpan.FromMilliseconds(configuracao.Timeout), certificado)
        {
            Configuracao = configuracao;
        }

        private Message WriteSoapEnvelope(string message, string soapAction)
        {
            var envelope = new StringBuilder();
            envelope.Append("<soap:Envelope xmlns:soap=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:gnr=\"http://www.gnre.pe.gov.br/webservice/GnreLoteRecepcao\">");
            envelope.Append("<soap:Header>");
            envelope.Append($"<gnr:gnreCabecMsg><gnr:versaoDados>{Convert.ToInt32(Configuracao.VersaoDados)}</gnr:versaoDados></gnr:gnreCabecMsg>");
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

        protected string Executar(string message, string soapAction, params string[] soapNamespaces)
        {
            var request = WriteSoapEnvelope(message, soapAction);

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
                    Guard.Against<ACBrDFeException>(response == null, "Nenhum retorno do webservice.");
                    var reader = response.GetReaderAtBodyContents();
                    soapResponse = reader.ReadOuterXml();
                }
            }
            finally
            {
                if (Configuracao.ValidarCertificado)
                    ServicePointManager.ServerCertificateValidationCallback = validation;
            }

            return soapResponse;

            //var xmlDocument = XDocument.Parse(soapResponse);
            //var retorno = TratarRetorno(xmlDocument, responseTag);
            //if (retorno.IsValidXml()) return retorno;

            //throw new ApplicationException(retorno);
        }               

        /// <summary>
        /// Salvar o arquivo xml no disco de acordo com as propriedades.
        /// </summary>
        /// <param name="conteudoArquivo"></param>
        /// <param name="nomeArquivo"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected virtual void GravarSoap(string conteudoArquivo, string nomeArquivo)
        {
            if (!Configuracao.SalvarSoap) return;

            string path = Path.Combine(Configuracao.PathXmls, nomeArquivo);
            File.WriteAllText(path, conteudoArquivo, Encoding.UTF8);
        }

        protected override void BeforeSendDFeRequest(string message)
        {
            EnvelopeEnvio = message;
            GravarSoap(EnvelopeEnvio, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoEnvio}_soap_env.xml");
        }

        protected override void AfterReceiveDFeReply(string message)
        {
            EnvelopeRetorno = message;
            GravarSoap(EnvelopeRetorno, $"{DateTime.Now:yyyyMMddssfff}_{PrefixoResposta}_soap_ret.xml");
        }

    }
}
