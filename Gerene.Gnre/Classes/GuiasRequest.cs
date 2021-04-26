using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("guias")]
    public sealed class GuiasRequest : DFeDocument<GuiasRequest>
    {
        [DFeCollection("TDadosGNRE")]
        public List<DadosGnreRequest> DadosGnre { get; set; }

        public GuiasRequest()
        {
            DadosGnre = new List<DadosGnreRequest>();
        }
    }
}
