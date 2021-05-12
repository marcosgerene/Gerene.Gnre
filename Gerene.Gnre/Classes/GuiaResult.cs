using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class GuiaResult : DFeDocument<GuiaResult>
    {
        [DFeElement(TipoCampo.Enum, "situacaoGuia")]
        public SituacaoGuia SituacaoGuia { get; set; }

        #region Dados Versao1
        [DFeElement(TipoCampo.Str, "c01_UfFavorecida")]
        public string UfFavorecidaV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c02_receita")]
        public string ReceitaV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c25_detalhamentoReceita")]
        public string DetalhamentoReceitaV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c26_produto")]
        public string ProdutoV1 { get; set; }

        [DFeElement(TipoCampo.Int, "c27_tipoIdentificacaoEmitente")]
        public int? TipoIdentificacaoEmitenteV1Proxy
        {
            get => TipoIdentificacaoEmitenteV1.HasValue ? (int?)Convert.ToInt32(TipoIdentificacaoEmitenteV1) : null;
            set
            {
                if (value.HasValue)
                    TipoIdentificacaoEmitenteV1 = (TipoIdentificacao)value.Value;
                else
                    TipoIdentificacaoEmitenteV1 = null;
            }
        }

        [DFeIgnore]
        public TipoIdentificacao? TipoIdentificacaoEmitenteV1 { get; set; }

        [DFeElement("c03_idContribuinteEmitente")]
        public IdContribuinte IdContribuinteEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c28_tipoDocOrigem")]
        public string TipoDocOrigemV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c04_docOrigem")]
        public string DocOrigemV1 { get; set; }

        [DFeElement(TipoCampo.De2, "c06_valorPrincipal")]
        public decimal? ValorPrincipalV1 { get; set; }

        [DFeElement(TipoCampo.De2, "c07_atualizacaoMonetaria")]
        public decimal? AtualizacaoMonetariaV1 { get; set; }

        [DFeElement(TipoCampo.De2, "c08_juros")]
        public decimal? JurosV1 { get; set; }

        [DFeElement(TipoCampo.De2, "c09_multa")]
        public decimal? MultaV1 { get; set; }

        [DFeElement(TipoCampo.De2, "c10_valorTotal")]
        public decimal? ValorTotal2V1 { get; set; }

        [DFeElement(TipoCampo.Dat, "c14_dataVencimento")]
        public DateTime? DataVencimentoV1 { get; set; }

        [DFeElement(TipoCampo.Dat, "c29_dataLimitePagamento")]
        public DateTime? DataLimitePagamentoV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c15_convenio")]
        public string ConvenioV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c16_razaoSocialEmitente")]
        public string RazaoSocialEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c17_inscricaoEstadualEmitente")]
        public string InscricaoEstadualEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c18_enderecoEmitente")]
        public string EnderecoEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Long, "c19_municipioEmitente")]
        public long? MunicipioEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c20_ufEnderecoEmitente")]
        public string UfEnderecoEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c21_cepEmitente")]
        public string CepEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c22_telefoneEmitente")]
        public string TelefoneEmitenteV1 { get; set; }

        [DFeElement(TipoCampo.Int, "c34_tipoIdentificacaoDestinatario")]
        public int? TipoIdentificacaoDestinatarioV1Proxy
        {
            get => TipoIdentificacaoDestinatarioV1.HasValue ? (int?)Convert.ToInt32(TipoIdentificacaoDestinatarioV1) : null;
            set
            {
                if (value.HasValue)
                    TipoIdentificacaoDestinatarioV1 = (TipoIdentificacao)value.Value;
                else
                    TipoIdentificacaoDestinatarioV1 = null;
            }
        }

        [DFeIgnore]
        public TipoIdentificacao? TipoIdentificacaoDestinatarioV1 { get; set; }

        [DFeElement("c35_idContribuinteDestinatario")]
        public IdContribuinte IdContribuinteDestinatarioV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c36_inscricaoEstadualDestinatario")]
        public string InscricaoEstadualDestinatarioV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c37_razaoSocialDestinatario")]
        public string RazaoSocialDestinatarioV1 { get; set; }

        [DFeElement(TipoCampo.Long, "c38_municipioDestinatario")]
        public long? MunicipioDestinatarioV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c23_informacoes")]
        public string InformacoesV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c30_nossoNumero")]
        public string NossoNumeroV1 { get; set; }

        [DFeElement(TipoCampo.Dat, "c33_dataPagamento")]
        public DateTime? DataPagamentoV1 { get; set; }

        [DFeElement("c05_referencia")]
        public Referencia ReferenciaV1 { get; set; }

        [DFeCollection("c39_camposExtras")]
        [DFeItem(typeof(CampoExtra), "campoExtra")]
        public List<CampoExtra> CamposExtrasV1 { get; set; }

        [DFeElement(TipoCampo.Str, "c42_identificadorGuia")]
        public string IdentificadorGuiaV1 { get; set; }
        #endregion Versao1

        #region Versao2
        [DFeElement(TipoCampo.Str, "ufFavorecida")]
        public string UfFavorecidaV2 { get; set; }

        [DFeIgnore]
        public TipoGnre? TipoGnreV2 { get; set; }

        [DFeElement(TipoCampo.Int, "tipoGnre")]
        public int? TipoGnreV2Proxy
        {
            get => TipoGnreV2.HasValue ? Convert.ToInt32(TipoGnreV2.Value) : (int?)null;
            set
            {
                if (value.HasValue)
                    TipoGnreV2 = (TipoGnre)value.Value;
                else
                    TipoGnreV2 = null;
            }
        }

        [DFeElement("contribuinteEmitente")]
        public ContribuinteEmitente IdContribuinteEmitenteV2 { get; set; }

        [DFeCollection("itensGNRE")]
        [DFeItem(typeof(ItemGnre), "item")]
        public List<ItemGnre> ItensGnreV2 { get; set; }

        [DFeElement(TipoCampo.De2, "valorGNRE")]
        public decimal? ValorGnreV2 { get; set; }

        [DFeElement(TipoCampo.Dat, "dataPagamento")]
        public DateTime? DataPagamentoV2 { get; set; }

        [DFeElement(TipoCampo.Str, "identificadorGuia")]
        public string IdentificadorGuiaV2 { get; set; }
        #endregion Versao2

        [DFeElement(TipoCampo.Dat, "dataLimitePagamento")]
        public DateTime? DataLimitePagamento { get; set; }

        [DFeCollection("informacoesComplementares")]
        [DFeItem(typeof(Informacao), "informacao")]
        public List<Informacao> InformacoesComplementares { get; set; }

        [DFeElement(TipoCampo.Str, "nossoNumero")]
        public string NossoNumero { get; set; }

        #region ResultadoGuia
        [DFeElement(TipoCampo.Str, "linhaDigitavel")]
        public string LinhaDigitavel { get; set; }

        [DFeElement(TipoCampo.Str, "codigoBarras")]
        public string CodigoBarras { get; set; }

        [DFeCollection("motivosRejeicao")]
        [DFeItem(typeof(Motivo), "motivo")]
        public List<Motivo> MotivosRejeicao { get; set; }
        #endregion
    }
}
