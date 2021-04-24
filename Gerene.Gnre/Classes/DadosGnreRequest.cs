using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    public sealed class DadosGnreRequest : DFeDocument<DadosGnreRequest>
    {
        public DadosGnreRequest(VersaoDados versao) : this()
        {
            switch (versao)
            {
                case VersaoDados.Versao1:
                    Versao = "1.00";
                    break;
                case VersaoDados.Versao2:
                    Versao = "2.00";
                    break;
                default:
                    throw new NotImplementedException($"Versão {versao} não implementada");
            }
        }

        internal DadosGnreRequest()
        {
        }

        [DFeAttribute(TipoCampo.Str, "versao", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Versao { get; internal set; }

        [DFeElement(TipoCampo.Str, "c01_UfFavorecida", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string UfFavorecida { get; set; }

        [DFeElement(TipoCampo.Str, "c02_receita", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public string Receita { get; set; }

        [DFeElement(TipoCampo.Str, "c25_detalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public string DetalhamentoReceita { get; set; }

        [DFeElement(TipoCampo.Str, "c26_produto", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 4)]
        public string Produto { get; set; }


        [DFeElement(TipoCampo.Int, "c27_tipoIdentificacaoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 5)]
        public int? TipoIdentificacaoEmitenteProxy
        {
            get => TipoIdentificacaoEmitente.HasValue ? (int?)Convert.ToInt32(TipoIdentificacaoEmitente) : null;
            set
            {
                if (value.HasValue)
                    TipoIdentificacaoEmitente = (TipoIdentificacao)value.Value;
                else
                    TipoIdentificacaoEmitente = null;
            }
        }

        [DFeIgnore]
        public TipoIdentificacao? TipoIdentificacaoEmitente { get; set; }

        [DFeElement("c03_idContribuinteEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 6)]
        public IdContribuinte IdContribuinteEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c28_tipoDocOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 7)]
        public string TipoDocOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "c04_docOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 8)]
        public string DocOrigem { get; set; }

        [DFeElement(TipoCampo.De2, "c06_valorPrincipal", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 9)]
        public decimal? ValorPrincipal { get; set; }

        [DFeElement(TipoCampo.De2, "c10_valorTotal", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 10)]
        public decimal? ValorTotal2 { get; set; }

        [DFeElement(TipoCampo.Dat, "c14_dataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 11)]
        public DateTime? DataVencimento { get; set; }

        [DFeElement(TipoCampo.Str, "c15_convenio", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 12)]
        public string Convenio { get; set; }

        [DFeElement(TipoCampo.Str, "c16_razaoSocialEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 13)]
        public string RazaoSocialEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c17_inscricaoEstadualEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 14)]
        public string InscricaoEstadualEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c18_enderecoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 15)]
        public string EnderecoEmitente { get; set; }

        [DFeElement(TipoCampo.Long, "c19_municipioEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 16)]
        public long? MunicipioEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c20_ufEnderecoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 17)]
        public string UfEnderecoEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c21_cepEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 18)]
        public string CepEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c22_telefoneEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 19)]
        public string TelefoneEmitente { get; set; }

        [DFeElement(TipoCampo.Int, "c34_tipoIdentificacaoDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 20)]
        public int? TipoIdentificacaoDestinatarioProxy
        {
            get => TipoIdentificacaoDestinatario.HasValue ? (int?)Convert.ToInt32(TipoIdentificacaoDestinatario) : null;
            set
            {
                if (value.HasValue)
                    TipoIdentificacaoDestinatario = (TipoIdentificacao)value.Value;
                else
                    TipoIdentificacaoDestinatario = null;
            }
        }

        [DFeIgnore]
        public TipoIdentificacao? TipoIdentificacaoDestinatario { get; set; }

        [DFeElement("c35_idContribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 21)]
        public IdContribuinte IdContribuinteDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "c36_inscricaoEstadualDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 22)]
        public string InscricaoEstadualDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "c37_razaoSocialDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 23)]
        public string RazaoSocialDestinatario { get; set; }

        [DFeElement(TipoCampo.Long, "c38_municipioDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 24)]
        public long? MunicipioDestinatario { get; set; }

        [DFeElement(TipoCampo.Dat, "c33_dataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 25)]
        public DateTime? DataPagamento { get; set; }

        [DFeElement("c05_referencia", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 26)]
        public Referencia Referencia { get; set; }

        [DFeElement("c39_camposExtras", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 27)]
        public CamposExtras CamposExtras { get; set; }

        [DFeElement(TipoCampo.Str, "c42_identificadorGuia", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 28)]
        public string IdentificadorGuia { get; set; }

    }

}