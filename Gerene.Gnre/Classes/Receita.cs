using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class StringCampo2_00
    {
        [DFeItemValue]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo2_00")]
        public string Campo2_00 { get; set; }
    }

    public sealed class ExigeCampo2_00
    {
        [DFeItemValue]
        public SimNao? Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo2_00")]
        public string Campo2_00 { get; set; }
    }

    public sealed class ValorExigidoCampo
    {
        [DFeItemValue]
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

        [DFeElement("detalhamentosReceita")]
        public DetalhamentosReceita DetalhamentosReceita { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeProduto", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigeProduto { get; set; }

        [DFeElement("produtos")]
        public Produtos Produtos { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoReferencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigePeriodoReferencia { get; set; }

        [DFeElement(TipoCampo.Enum, "exigePeriodoApuracao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigePeriodoApuracao { get; set; }

        [DFeElement("periodosApuracao")]
        public PeriodosApuracao PeriodosApuracao { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeParcela", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeParcela { get; set; }

        [DFeElement(TipoCampo.Enum, "valorExigido", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ValorExigidoCampo ValorExigido { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDocumentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo2_00 ExigeDocumentoOrigem { get; set; }

        [DFeElement("tiposDocumentosOrigem")]
        public TiposDocumentosOrigem TiposDocumentosOrigem { get; set; }
        
        [DFeElement("versoesXmlDocOrigem")]
        public VersoesXml VersoesXmlDocOrigem { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeContribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeContribuinteDestinatario { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeDataVencimento { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeDataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeDataPagamento { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeConvenio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeConvenio { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeValorFecp", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeValorFecp { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeCamposAdicionais", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public ExigeCampo ExigeCamposAdicionais { get; set; }

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
