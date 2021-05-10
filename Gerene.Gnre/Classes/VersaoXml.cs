using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class VersaoXml
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Versao { get; set; }
    }
}