using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class CamposAdicionais : DFeDocument<CamposAdicionais>
    {
        [DFeCollection("campoAdicional")]
        public List<CampoAdicional> CampoAdicional { get; set; }
    }
}
