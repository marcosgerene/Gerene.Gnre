using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class DetalhamentosReceita : DFeDocument<DetalhamentosReceita>
    {
        [DFeCollection("detalhamentoReceita")]
        public List<DetalhamentoReceita> DetalhamentoReceita { get; set; }
    }
}
