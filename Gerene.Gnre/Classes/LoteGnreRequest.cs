using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
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

    [DFeRoot("TLote_GNRE", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class LoteGnreRequest : DFeDocument<LoteGnreRequest>
    {
        [DFeAttribute(TipoCampo.Str, "versao")]
        public string Versao { get; set; }

        [DFeCollection("guias")]
        public GuiasRequest Guias { get; set; }
        
        public LoteGnreRequest()
        {
            Versao = "2.00";
            Guias = new GuiasRequest();
        }
    }
}