using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class Receitas : DFeDocument<Receita>
    {
        [DFeCollection("receita")]
        public List<Receita> Receita { get; set; }

        public Receitas()
        {
            Receita = new List<Receita>();
        }
    }
}
