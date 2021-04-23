using System;

using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;

namespace Gerene.GNRe.WebService
{
    public sealed class ServicoRecepcaoLote : WebServiceClient
    {
        private const string Url = @"http://www.gnre.pe.gov.br/gnreWS/services/GnreConfigUF?wsdl";

        public ServicoRecepcaoLote(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url, configuracao, certificado)
        {
        }

        public string Processar(string xml)
        {
            PrefixoEnvio = "RecepcaoLoteEnvio";
            PrefixoResposta = "RecepcaoLoteRetorno";

            return Executar(xml, "processar");
        }       

    }
}
