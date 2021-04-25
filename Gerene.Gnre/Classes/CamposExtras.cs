using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class CamposExtras : DFeDocument<CamposExtras>
    {
        [DFeCollection("campoExtra")]
        public List<CampoExtra> CampoExtra { get; set; }
    }
}