using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TLote_GNRE", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class LoteGnreRequest : DFeDocument<LoteGnreRequest>
    {
        [DFeAttribute(TipoCampo.Str, "versao")]
        public string Versao { get; set; }

        [DFeElement("guias")]
        public GuiasRequest Guias { get; set; }

        public LoteGnreRequest()
        {
            Versao = "2.00";
            Guias = new GuiasRequest();
        }
    }
}