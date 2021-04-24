using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class TiposDocumentosOrigem : DFeDocument<TiposDocumentosOrigem>
    {
        [DFeCollection("tipoDocumentoOrigem")]
        public List<TipoDocumentoOrigem> TipoDocumentoOrigem { get; set; }
    }
}
