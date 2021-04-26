using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class ItensGnre : DFeDocument<ItensGnre>
    {
        [DFeCollection("item")]
        public List<ItemGnre> Item { get; set; }
    }
}
