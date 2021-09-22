using OpenAC.Net.DFe.Core.Common;
using Gerene.Gnre.Classes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Gerene.Gnre.WebService
{
    public sealed class ServicoConfigUf : WebServiceClient
    {
        private const string UrlProducao = @"https://www.gnre.pe.gov.br/gnreWS/services/GnreConfigUF?wsdl";
        private const string UrlHomologacao = @"https://www.testegnre.pe.gov.br/gnreWS/services/GnreConfigUF?wsdl";
        private const string ArquivoSchema = @"consulta_config_uf_v1.00.xsd";

        public ServicoConfigUf(ConfiguracaoWebService configuracao, X509Certificate2 certificado) : base(Url(configuracao), configuracao, certificado)
        {
        }

        private static string Url(ConfiguracaoWebService configuracao) =>
            configuracao.Ambiente == TipoAmbiente.Homologacao ? UrlHomologacao :
            configuracao.Ambiente == TipoAmbiente.Producao ? UrlProducao :
            throw new NotImplementedException($"Ambiente \"{configuracao.Ambiente}\" não implementado");

        public ConsultaConfigUfResult Consultar(ConsultaConfigUfRequest request)
        {
            PrefixoEnvio = "ConfigUfEnvio";
            PrefixoResposta = "ConfigUfRetorno";

            string innerxml = request.GetXml(DFeSaveOptions.DisableFormatting | DFeSaveOptions.OmitDeclaration | DFeSaveOptions.RemoveSpaces);

            if (Configuracao.ValidarSchemas)
                new Validador(Configuracao).Validar(innerxml, ArquivoSchema);

            string resposta = Executar(innerxml, "http://www.gnre.pe.gov.br/webservice/GnreConfigUF", VersaoDados.Versao1, "consultar");

            return ConsultaConfigUfResult.Load(resposta);
        }
    }
}
