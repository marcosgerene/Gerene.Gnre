using Gerene.Gnre.Classes;

using System;
using System.IO;
using System.Threading.Tasks;

namespace Gerene.Gnre.WebService
{
    public sealed class GnreClient
    {
        public ConfiguracaoCertificado ConfiguracaoCertificado { get; set; }
        public ConfiguracaoWebService ConfiguracaoWebService { get; set; }

        public string XmlEnvio { get; private set; }
        public string XmlResposta { get; private set; }

        public GnreClient()
        {
            ConfiguracaoCertificado = new ConfiguracaoCertificado()
            {
                Tipo = TipoCertificado.A1Repositorio,
                Serial = null,
                Senha = null,
                Path = null,
                ArrayBytes = null,
            };

            ConfiguracaoWebService = new ConfiguracaoWebService()
            {
                Ambiente = TipoAmbiente.Homologacao,

                Timeout = 30000,

                ValidarCertificado = true,

                DiretorioXmls = string.Empty,
                SalvarXmls = true,
                SalvarSoap = false,

                ValidarSchemas = true,
                DiretorioSchemas = string.Empty,
            };
        }

        #region RecepcaoLote
        public async Task<RecepcaoLoteResult> RecepcaoLoteAsync(LoteGnreRequest request)
        {
            RecepcaoLoteResult resposta = null;

            await Task.Run(() =>
            {
                using (var certificado = CertificadoDigital.ObterDadosCertificado(ConfiguracaoCertificado))
                {
                    using (var servico = new ServicoRecepcaoLote(ConfiguracaoWebService, certificado))
                    {
                        try
                        {
                            resposta = servico.Processar(request);
                        }
                        finally
                        {
                            XmlEnvio = servico.XmlEnvio;
                            XmlResposta = servico.XmlResposta;
                        }
                    }
                }
            });

            return resposta;
        }

        public RecepcaoLoteResult RecepcaoLote(LoteGnreRequest request)
        {
            RecepcaoLoteResult resposta = null;

            Task task = Task.Run(async () =>
            {
                resposta = await RecepcaoLoteAsync(request);
            });

            task.Wait();

            return resposta;
        }
        #endregion

        #region ResultadoLote
        public async Task<ConsultarLoteResult> ResultadoLoteAsync(string numeroRecibo, bool incluirPdf)
        {

            var request = new ConsultaLoteRequest()
            {
                Ambiente = ConfiguracaoWebService.Ambiente,
                NumeroRecibo = numeroRecibo,
                IncluirPdfsGuias = incluirPdf
            };

            ConsultarLoteResult resposta = null;

            await Task.Run(() =>
            {
                using (var certificado = CertificadoDigital.ObterDadosCertificado(ConfiguracaoCertificado))
                {
                    using (var servico = new ServicoResultadoLote(ConfiguracaoWebService, certificado))
                    {
                        try
                        {
                            resposta = servico.Consultar(request);
                        }
                        finally
                        {
                            XmlEnvio = servico.XmlEnvio;
                            XmlResposta = servico.XmlResposta;
                        }
                    }
                }
            });

            return resposta;
        }

        public ConsultarLoteResult ResultadoLote(string numeroRecibo, bool incluirPdf)
        {
            ConsultarLoteResult resposta = null;

            Task task = Task.Run(async () =>
            {
                resposta = await ResultadoLoteAsync(numeroRecibo, incluirPdf);
            });

            task.Wait();

            return resposta;
        }
        #endregion

        #region ConfigUf
        public async Task<ConsultaConfigUfResult> ConfigUfAsync(string uf, string receita = null, SimNao? courier = null)
        {
            var request = new ConsultaConfigUfRequest()
            {
                Ambiente = ConfiguracaoWebService.Ambiente,
                Uf = uf,
                Receita = receita,
                Courier = courier
            };

            ConsultaConfigUfResult resposta = null;

            await Task.Run(() =>
            {
                using (var certificado = CertificadoDigital.ObterDadosCertificado(ConfiguracaoCertificado))
                {
                    using (var servico = new ServicoConfigUf(ConfiguracaoWebService, certificado))
                    {
                        try
                        {
                            resposta = servico.Consultar(request);
                        }
                        finally
                        {
                            XmlEnvio = servico.XmlEnvio;
                            XmlResposta = servico.XmlResposta;
                        }
                    }
                }
            });

            return resposta;
        }

        public ConsultaConfigUfResult ConfigUf(string uf, string receita = null, SimNao? courier = null)
        {
            ConsultaConfigUfResult resposta = null;

            Task task = Task.Run(async () =>
            {
                resposta = await ConfigUfAsync(uf, receita, courier);
            });

            task.Wait();

            return resposta;
        }
        #endregion

    }
}
