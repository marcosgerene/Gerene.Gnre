using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class CamposExtras : DFeDocument<CamposExtras>
    {
        [DFeElement(TipoCampo.Int, "codigo")]
        public int Codigo { get; set; }

        [DFeElement(TipoCampo.Enum, "tipo")]
        public TipoCampoExtra? Tipo { get; set; }

        [DFeElement(TipoCampo.Str, "valor")]
        public int Valor { get; set; }
    }
}