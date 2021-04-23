using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Gerene.GNRe.WebService
{
    public sealed class ServicoConfigUf : WebServiceClient
    {
        private const string Url = @"http://www.gnre.pe.gov.br/gnreWS/services/GnreLoteRecepcao?wsdl";

        public ServicoConfigUf(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url, configuracao, certificado)
        {
        }

        public string Consultar(string xml)
        {
            PrefixoEnvio = "ConfigUfEnvio";
            PrefixoResposta = "ConfigUfRetorno";

            return Executar(xml, "consultar");
        }
    }
}
