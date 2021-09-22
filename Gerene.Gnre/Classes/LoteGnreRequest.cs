using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TLote_GNRE", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class LoteGnreRequest : DFeDocument<LoteGnreRequest>
    {
        [DFeAttribute(TipoCampo.Str, "versao")]
        public string Versao { get; set; }

        [DFeCollection("guias")]
        [DFeItem(typeof(DadosGnreRequest), "TDadosGNRE")]
        public List<DadosGnreRequest> Guias { get; set; }

        public LoteGnreRequest()
        {
            Versao = "2.00";
            Guias = new List<DadosGnreRequest>();
        }
    }
}