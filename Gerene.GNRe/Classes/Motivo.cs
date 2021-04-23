using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.GNRe.Classes
{
    public sealed class Motivo : DFeDocument<Motivo>
    {
        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Str, "campo")]
        public string Campo { get; set; }
    }
}
