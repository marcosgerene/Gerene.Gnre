using ACBr.Net.DFe.Core.Common;
using Gerene.Gnre.Classes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Gerene.Gnre.WebService
{
    public sealed class ServicoResultadoLote : WebServiceClient
    {
        private const string UrlProducao = @"https://www.gnre.pe.gov.br/gnreWS/services/GnreResultadoLote?wsdl";
        private const string UrlHomologacao = @"https://www.testegnre.pe.gov.br/gnreWS/services/GnreResultadoLote?wsdl";
        private const string ArquivoSchema = @"lote_gnre_consulta_v1.00.xsd";

        public ServicoResultadoLote(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url(configuracao), configuracao, certificado)
        {
        }

        private static string Url(ConfiguracaoWebService configuracao) =>
            configuracao.Ambiente == TipoAmbiente.Homologacao ? UrlHomologacao :
            configuracao.Ambiente == TipoAmbiente.Producao ? UrlProducao :
            throw new NotImplementedException($"Ambiente \"{configuracao.Ambiente}\" não implementado");

        public ConsultarLoteResult Consultar(ConsultaLoteRequest request)
        {
            PrefixoEnvio = "ResultadoLoteEnvio";
            PrefixoResposta = "ResultadoLoteRetorno";

            string innerxml = request.GetXml(DFeSaveOptions.DisableFormatting | DFeSaveOptions.OmitDeclaration | DFeSaveOptions.RemoveSpaces);

            if (Configuracao.ValidarSchemas)
                new Validador(Configuracao).Validar(innerxml, ArquivoSchema);

            string resposta = Executar(innerxml, "http://www.gnre.pe.gov.br/webservice/GnreResultadoLote", VersaoDados.Versao2, "consultar");

            return ConsultarLoteResult.Load(resposta);
        }
    }
}