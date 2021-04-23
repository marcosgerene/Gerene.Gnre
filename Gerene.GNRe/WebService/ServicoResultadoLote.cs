using Gerene.GNRe.Classes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;

namespace Gerene.GNRe.WebService
{
    public sealed class ServicoResultadoLote : WebServiceClient
    {
        private const string Url = @"http://www.gnre.pe.gov.br/gnreWS/services/GnreResultadoLote?wsdl";

        public ServicoResultadoLote(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url, configuracao, certificado)
        {
        }

        public string Consultar(ConsultaLoteRequest request)
        {
            PrefixoEnvio = "ResultadoLoteEnvio";
            PrefixoResposta = "ResultadoLoteRetorno";

            string innerxml = request.GetXml();

            return Executar(innerxml, "consultar");
        }
    }
}