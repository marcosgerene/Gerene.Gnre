using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class VersaoXml
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Versao { get; set; }
    }
}