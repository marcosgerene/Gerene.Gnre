using Gerene.Gnre.Classes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;

namespace Gerene.Gnre.WebService
{
    public sealed class ServicoResultadoLote : WebServiceClient
    {
        private const string UrlProducao = @"https://www.gnre.pe.gov.br/gnreWS/services/GnreResultadoLote?wsdl";
        private const string UrlHomologacao = @"http://www.testegnre.pe.gov.br/gnreWS/services/GnreResultadoLote?wsdl";

        public ServicoResultadoLote(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url(configuracao), configuracao, certificado)
        {
        }

        private static string Url(ConfiguracaoWebService configuracao) =>
            configuracao.Ambiente == TipoAmbiente.Homologacao ? UrlHomologacao :
            configuracao.Ambiente == TipoAmbiente.Producao ? UrlProducao :
            throw new NotImplementedException($"Ambiente \"{configuracao.Ambiente}\" não implementado");

        public  ConsultarLoteResult Consultar(ConsultaLoteRequest request)
        {
            PrefixoEnvio = "ResultadoLoteEnvio";
            PrefixoResposta = "ResultadoLoteRetorno";

            string innerxml = request.GetXml();           

            string resposta =  Executar(innerxml, "http://www.gnre.pe.gov.br/webservice/GnreResultadoLote", VersaoDados.Versao2, "consultar");

            return null;
        }
    }
}