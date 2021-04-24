using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class Produtos : DFeDocument<Produtos>
    {
        [DFeCollection("produto")]
        public List<Produto> Produto { get; set; }
    }
}
