using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class TiposDocumentosOrigem : DFeDocument<TiposDocumentosOrigem>
    {
        [DFeCollection("tipoDocumentoOrigem")]
        public List<TipoDocumentoOrigem> TipoDocumentoOrigem { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        public TiposDocumentosOrigem()
        {
            TipoDocumentoOrigem = new List<TipoDocumentoOrigem>();
        }
    }
}
