using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class ContribuinteDestinatario : DFeDocument<ContribuinteDestinatario>
    {
        [DFeElement("identificacao", Ordem = 1)]
        public IdContribuinte IdContribuinteEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "razaoSocial", Ordem = 2)]
        public string RazaoSocial { get; set; }

        [DFeElement(TipoCampo.Long, "municipio", Ordem = 3, Min = 5, Max = 5)]
        public long? Municipio { get; set; }
    }
}
