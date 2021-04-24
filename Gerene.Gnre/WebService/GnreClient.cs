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

        public GnreClient()
        {
            ConfiguracaoCertificado = new ConfiguracaoCertificado()
            {
                Tipo = TipoCertificado.A1Repositorio,
                Serial = "05d75a9b9829a807",
                Senha = null,
                Path = null,
                ArrayBytes = null,
            };

            ConfiguracaoWebService = new ConfiguracaoWebService()
            {
                Ambiente = TipoAmbiente.Homologacao,

                Timeout = 30000,

                ValidarCertificado = true,

                DiretorioXmls = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Gnre"),
                SalvarXmls = true,
                SalvarSoap = false,

                ValidarSchemas = true,
                DiretorioSchemas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Schemas"),
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
                        resposta = servico.Processar(request);
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
                        resposta = servico.Consultar(request);
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
        public async Task<ConsultaConfigUfResult> ConfigUfAsync(string uf, string receita, SimNao? courier = null)
        {

            var request = new ConsultaConfigUfRequest()
            {
                Ambiente = ConfiguracaoWebService.Ambiente,
                Uf = uf,
                Receita = receita,
                //Courier = courier
            };

            ConsultaConfigUfResult resposta = null;

            await Task.Run(() =>
            {
                using (var certificado = CertificadoDigital.ObterDadosCertificado(ConfiguracaoCertificado))
                {
                    using (var servico = new ServicoConfigUf(ConfiguracaoWebService, certificado))
                    {
                        resposta = servico.Consultar(request);
                    }
                }
            });

            return resposta;
        }

        public ConsultaConfigUfResult ConfigUf(string uf, string receita, SimNao? courier = null)
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
