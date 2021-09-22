using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class CampoExtra2
    {
        [DFeElement(TipoCampo.Int, "codigo")]
        public int Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "valor")]
        public string Valor { get; set; }
    }
}
