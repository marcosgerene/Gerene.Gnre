using Gerene.Gnre.Classes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Gerene.Gnre.WebService
{
    public sealed class ServicoRecepcaoLote : WebServiceClient
    {
        private const string UrlProducao = @"http://www.gnre.pe.gov.br/gnreWS/services/GnreLoteRecepcao?wsdl";
        private const string UrlHomologacao = @"http://www.testegnre.pe.gov.br/gnreWS/services/GnreLoteRecepcao?wsdl";

        public ServicoRecepcaoLote(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url(configuracao), configuracao, certificado)
        {
        }

        private static string Url(ConfiguracaoWebService configuracao) =>
            configuracao.Ambiente == TipoAmbiente.Homologacao ? UrlHomologacao :
            configuracao.Ambiente == TipoAmbiente.Producao ? UrlProducao :
            throw new NotImplementedException($"Ambiente \"{configuracao.Ambiente}\" não implementado");

        public string Processar(string innerxml)
        {
            PrefixoEnvio = "RecepcaoLoteEnvio";
            PrefixoResposta = "RecepcaoLoteRetorno";

            string resposta = Executar(innerxml, "http://www.gnre.pe.gov.br/webservice/GnreLoteRecepcao", VersaoDados.Versao2, "consultar");

            return null;
        }       

    }
}
