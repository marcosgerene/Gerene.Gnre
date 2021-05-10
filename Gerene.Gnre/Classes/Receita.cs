using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class StringCampo2_00
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo2_00")]
        public string Campo2_00 { get; set; }
    }

    public sealed class ExigeCampo2_00
    {
        [DFeItemValue(Tipo = TipoCampo.Enum)]
        public SimNao? Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo2_00")]
        public string Campo2_00 { get; set; }
    }

    public sealed class ValorExigidoCampo
    {
        [DFeItemValue(Tipo = TipoCampo.Enum)]
        public ValorExigido? Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }
    }

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
        public ExigeCampo2_00 ExigeDetalhamentoReceita { get; set; }

        [DFeCollection("detalhamentosReceita")]
        [DFeItem(typeof(DetalhamentoReceita), "detalhamentoReceita")]
        public List<DetalhamentoReceita> DetalhamentosReceita { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeProduto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigeProduto { get; set; }

        [DFeCollection("produtos")]
        [DFeItem(typeof(Produto),"produto")]
        public List<Produto> Produtos { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoReferencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigePeriodoReferencia { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoApuracao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigePeriodoApuracao { get; set; }

        [DFeCollection("periodosApuracao")]
        [DFeItem(typeof(PeriodoApuracao), "periodoApuracao")]
        public List<PeriodoApuracao> PeriodosApuracao { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeParcela", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeParcela { get; set; }

        [DFeElement(TipoCampo.Enum, "valorExigido", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ValorExigidoCampo ValorExigido { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDocumentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigeDocumentoOrigem { get; set; }

        [DFeElement("tiposDocumentosOrigem")]
        public TiposDocumentosOrigem TiposDocumentosOrigem { get; set; }
        
        [DFeCollection("versoesXmlDocOrigem")]
        [DFeItem(typeof(VersaoXml), "versao")]
        public List<VersaoXml> VersoesXmlDocOrigem { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeContribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeContribuinteDestinatario { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeDataVencimento { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeDataPagamento { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeConvenio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeConvenio { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeValorFecp", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeValorFecp { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeCamposAdicionais", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeCamposAdicionais { get; set; }

        [DFeCollection("camposAdicionais")]
        [DFeItem(typeof(CampoAdicional), "campoAdicional")]
        public List<CampoAdicional> CamposAdicionais { get; set; }

        public Receita()
        {
            DetalhamentosReceita = new List<DetalhamentoReceita>();
            Produtos = new List<Produto>();
            PeriodosApuracao = new List<PeriodoApuracao>();
            TiposDocumentosOrigem = new TiposDocumentosOrigem();
            VersoesXmlDocOrigem = new List<VersaoXml>();
            CamposAdicionais = new List<CampoAdicional>();
        }
    }
}
