using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class InformacoesComplementares : DFeDocument<InformacoesComplementares>
    {
        [DFeCollection("informacao")]
        public List<string> Informacao { get; set; }
    }
}
