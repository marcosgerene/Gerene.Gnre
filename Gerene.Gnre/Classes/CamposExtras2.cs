using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    public sealed class CamposExtras2 : DFeDocument<CamposExtras2>
    {
        [DFeCollection("campoExtra")]
        public List<CampoExtra2> CampoExtra { get; set; }
    }
}
