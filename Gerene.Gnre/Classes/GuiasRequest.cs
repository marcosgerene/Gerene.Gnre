using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("guias")]
    public sealed class GuiasRequest : DFeDocument<GuiasRequest>
    {
        [DFeCollection("TDadosGNRE")]
        public List<DadosGnreRequestVersao1> DadosGnreVersao1 { get; set; }

        [DFeCollection("TDadosGNRE")]
        public List<DadosGnreRequestVersao2> DadosGnreVersao2 { get; set; }

        public GuiasRequest()
        {
            DadosGnreVersao1 = new List<DadosGnreRequestVersao1>();
            DadosGnreVersao2 = new List<DadosGnreRequestVersao2>();
        }
    }
}
