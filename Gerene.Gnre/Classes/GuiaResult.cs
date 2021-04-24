using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class GuiaResult : DFeDocument<GuiaResult>
    {
        [DFeIgnore]
        public SituacaoGuia SituacaoGuia { get; set; }

        [DFeElement(TipoCampo.Int, "situacaoGuia")]
        public int SituacaoGuiaProxy
        {
            get => Convert.ToInt32(SituacaoGuia);
            set => SituacaoGuia = (SituacaoGuia)value;
        }

        [DFeElement(TipoCampo.Str, "c01_UfFavorecida", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string UfFavorecida { get; set; }

        [DFeElement(TipoCampo.Str, "c02_receita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Receita { get; set; }

        [DFeElement(TipoCampo.Str, "c25_detalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string DetalhamentoReceita { get; set; }

        [DFeElement(TipoCampo.Str, "c26_produto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Produto { get; set; }


        [DFeElement(TipoCampo.Int, "c27_tipoIdentificacaoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
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

        [DFeElement("c03_idContribuinteEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public IdContribuinte IdContribuinteEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c28_tipoDocOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string TipoDocOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "c04_docOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string DocOrigem { get; set; }

        [DFeElement(TipoCampo.De2, "c06_valorPrincipal", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public decimal? ValorPrincipal { get; set; }

        [DFeElement(TipoCampo.De2, "c07_atualizacaoMonetaria", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public decimal? AtualizacaoMonetaria { get; set; }

        [DFeElement(TipoCampo.De2, "c08_juros", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public decimal? Juros { get; set; }

        [DFeElement(TipoCampo.De2, "c09_multa", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public decimal? Multa { get; set; }

        [DFeElement(TipoCampo.De2, "c10_valorTotal", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public decimal? ValorTotal2 { get; set; }

        [DFeElement(TipoCampo.Dat, "c14_dataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DateTime? DataVencimento { get; set; }

        [DFeElement(TipoCampo.Dat, "c29_dataLimitePagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DateTime? DataLimitePagamento { get; set; }
        
        [DFeElement(TipoCampo.Str, "c15_convenio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Convenio { get; set; }

        [DFeElement(TipoCampo.Str, "c16_razaoSocialEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string RazaoSocialEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c17_inscricaoEstadualEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string InscricaoEstadualEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c18_enderecoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string EnderecoEmitente { get; set; }

        [DFeElement(TipoCampo.Long, "c19_municipioEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public long? MunicipioEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c20_ufEnderecoEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string UfEnderecoEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c21_cepEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CepEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "c22_telefoneEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string TelefoneEmitente { get; set; }

        [DFeElement(TipoCampo.Int, "c34_tipoIdentificacaoDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
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

        [DFeElement("c35_idContribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public IdContribuinte IdContribuinteDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "c36_inscricaoEstadualDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string InscricaoEstadualDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "c37_razaoSocialDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string RazaoSocialDestinatario { get; set; }

        [DFeElement(TipoCampo.Long, "c38_municipioDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public long? MunicipioDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "c23_informacoes", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Informacoes { get; set; }

        [DFeElement(TipoCampo.Str, "c30_nossoNumero", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string NossoNumero { get; set; }

        [DFeElement(TipoCampo.Dat, "c33_dataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DateTime? DataPagamento { get; set; }

        [DFeElement("c05_referencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public Referencia Referencia { get; set; }

        [DFeElement("c39_camposExtras", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public CamposExtras CamposExtras { get; set; }

        [DFeElement(TipoCampo.Str, "c42_identificadorGuia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string IdentificadorGuia { get; set; }

        [DFeElement(TipoCampo.Str, "representacaoNumerica")]
        public string RepresentacaoNumerica { get; set; }

        [DFeElement(TipoCampo.Str, "codigoBarras")]
        public string CodigoBarras { get; set; }

        [DFeElement(TipoCampo.Str, "linhaDigitavel")]
        public string LinhaDigitavel { get; set; }

        [DFeCollection("motivosRejeicao")]
        public List<Motivo> MotivosRejeicao { get; set; }

    }
}
