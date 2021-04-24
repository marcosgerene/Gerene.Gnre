using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class Guia : DFeDocument<Guia>
    {
        [DFeIgnore]
        public SituacaoGuia SituacaoGuia { get; set; }

        [DFeElement(TipoCampo.Int, "situacaoGuia")]
        public int SituacaoGuiaProxy
        {
            get => Convert.ToInt32(SituacaoGuia);
            set => SituacaoGuia = (SituacaoGuia)value;
        }

        //DadosGnre
        /*
         <c01_UfFavorecida>AL</c01_UfFavorecida>
      <c02_receita>c02_receita2</c02_receita>
      <c25_detalhamentoReceita>c25_detalhamentoReceita2</c25_detalhamentoReceita>
      <c26_produto>c26_produto2</c26_produto>
      <c27_tipoIdentificacaoEmitente>2</c27_tipoIdentificacaoEmitente>
      <c03_idContribuinteEmitente>
        <CNPJ>CNPJ2</CNPJ>
      </c03_idContribuinteEmitente>
      <c28_tipoDocOrigem>c28_tipoDocOrigem2</c28_tipoDocOrigem>
      <c04_docOrigem>c04_docOrigem2</c04_docOrigem>
      <c06_valorPrincipal>c06_valorPrincipal2</c06_valorPrincipal>
      <c07_atualizacaoMonetaria>c07_atualizacaoMonetaria2</c07_atualizacaoMonetaria>
      <c08_juros>c08_juros2</c08_juros>
      <c09_multa>c09_multa2</c09_multa>
      <c10_valorTotal>c10_valorTotal2</c10_valorTotal>
      <c14_dataVencimento>c14_dataVencimento2</c14_dataVencimento>
      <c29_dataLimitePagamento>c29_dataLimitePagamento2</c29_dataLimitePagamento>
      <c15_convenio>c15_convenio2</c15_convenio>
      <c16_razaoSocialEmitente>c16_razaoSocialEmitente2</c16_razaoSocialEmitente>
      <c17_inscricaoEstadualEmitente>c17_inscricaoEstadualEmitente2</c17_inscricaoEstadualEmitente>
      <c18_enderecoEmitente>c18_enderecoEmitente2</c18_enderecoEmitente>
      <c19_municipioEmitente>c19_municipioEmitente2</c19_municipioEmitente>
      <c20_ufEnderecoEmitente>AL</c20_ufEnderecoEmitente>
      <c21_cepEmitente>c21_cepEmitente2</c21_cepEmitente>
      <c22_telefoneEmitente>c22_telefoneEmitente2</c22_telefoneEmitente>
      <c34_tipoIdentificacaoDestinatario>2</c34_tipoIdentificacaoDestinatario>
      <c35_idContribuinteDestinatario>
        <CNPJ>CNPJ2</CNPJ>
      </c35_idContribuinteDestinatario>
      <c36_inscricaoEstadualDestinatario>c36_inscricaoEstadualDestinatario2</c36_inscricaoEstadualDestinatario>
      <c37_razaoSocialDestinatario>c37_razaoSocialDestinatario2</c37_razaoSocialDestinatario>
      <c38_municipioDestinatario>c38_municipioDestinatario2</c38_municipioDestinatario>
      <c23_informacoes>c23_informacoes2</c23_informacoes>
      <c30_nossoNumero>c30_nossoNumero2</c30_nossoNumero>
      <c33_dataPagamento>c33_dataPagamento2</c33_dataPagamento>
      <c05_referencia>
        <periodo>1</periodo>
        <mes>02</mes>
        <ano>ano2</ano>
        <parcela>parcela2</parcela>
      </c05_referencia>
      <c39_camposExtras>
        <campoExtra>
          <codigo>0</codigo>
          <tipo>T</tipo>
          <valor>valor4</valor>
        </campoExtra>
        <campoExtra>
          <codigo>2</codigo>
          <tipo>N</tipo>
          <valor>valor5</valor>
        </campoExtra>
        <campoExtra>
          <codigo>-2147483646</codigo>
          <tipo>D</tipo>
          <valor>valor6</valor>
        </campoExtra>
      </c39_camposExtras>
      <c42_identificadorGuia>c42_ident2</c42_identificadorGuia>
      */

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
