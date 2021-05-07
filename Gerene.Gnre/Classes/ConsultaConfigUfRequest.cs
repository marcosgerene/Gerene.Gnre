using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class ReceitaValue
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Enum, "courier", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Courier { get; set; }
    }

    [DFeRoot("TConsultaConfigUf", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class ConsultaConfigUfRequest : DFeDocument<ConsultaConfigUfRequest>
    {
        [DFeElement(TipoCampo.Enum, "ambiente", Ordem = 1)]
        public TipoAmbiente Ambiente { get; set; }
    
        [DFeElement(TipoCampo.Str, "uf", Ordem = 2)]
        public string Uf { get; set; }

        [DFeElement("receita", Tipo = TipoCampo.Str, Ordem = 3)]
        public ReceitaValue Receita { get; set; }

    }
}
