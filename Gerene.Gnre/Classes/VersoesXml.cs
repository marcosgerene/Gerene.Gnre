using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class VersoesXml : DFeDocument<VersoesXml>
    {
        [DFeElement(TipoCampo.Str, "versao")]
        public List<string> Versao { get; set; }
    }
}
