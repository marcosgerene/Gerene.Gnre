using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class Situacao : DFeDocument<Situacao>
    {
        [DFeElement(TipoCampo.Int, "codigo")]
        public int Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }
    }
}
