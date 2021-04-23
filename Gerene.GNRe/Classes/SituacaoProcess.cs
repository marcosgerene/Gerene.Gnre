using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.GNRe.Classes
{
    public sealed class SituacaoProcess : DFeDocument<SituacaoProcess>
    {
        [DFeElement(TipoCampo.Int, "codigo")]
        public int Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }
    }
}
