using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    public sealed class Receita : DFeDocument<Receita>
    {
        [DFeAttribute(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeAttribute(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeAttribute(TipoCampo.Enum, "courier", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Courier { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeContribuinteEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeContribuinteEmitente { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDetalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeDetalhamentoReceita { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeDetalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo2_00 - exigeDetalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo2_00 { get; set; }

        [DFeElement("detalhamentosReceita")]
        public DetalhamentosReceita DetalhamentosReceita { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeProduto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeProduto { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeProduto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo2_00 - exigeProduto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo2_00 { get; set; }

        [DFeElement("produtos")]
        public Produtos Produtos { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoReferencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigePeriodoReferencia { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigePeriodoReferencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoApuracao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigePeriodoApuracao { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigePeriodoApuracao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo2_00 - exigePeriodoApuracao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo2_00 { get; set; }

        [DFeElement("periodosApuracao")]
        public PeriodosApuracao PeriodosApuracao { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeParcela", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeParcela { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeParcela", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "valorExigido", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ValorExigido ? ValorExigido { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - valorExigido", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDocumentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeDocumentoOrigem { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeDocumentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo2_00 - exigeDocumentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo2_00 { get; set; }
                
        [DFeElement("tiposDocumentosOrigem")]
        public TiposDocumentosOrigem TiposDocumentosOrigem { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - tiposDocumentosOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement("versoesXmlDocOrigem")]
        public VersoesXml VersoesXmlDocOrigem { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeContribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeContribuinteDestinatario { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeDataVencimento { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeDataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeDataPagamento { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeDataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeConvenio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeConvenio { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeConvenio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeValorFecp", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeValorFecp { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeValorFecp", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeCamposAdicionais", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeCamposAdicionais { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - exigeCamposAdicionais", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement("camposAdicionais")]
        public CamposAdicionais CamposAdicionais { get; set; }

        public Receita()
        {
            DetalhamentosReceita = new DetalhamentosReceita();
            Produtos = new Produtos();
            PeriodosApuracao = new PeriodosApuracao();
            TiposDocumentosOrigem = new TiposDocumentosOrigem();
            VersoesXmlDocOrigem = new VersoesXml();
            CamposAdicionais = new CamposAdicionais();
        }
    }
}
