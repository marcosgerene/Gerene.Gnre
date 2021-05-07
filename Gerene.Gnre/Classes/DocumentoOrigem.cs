using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class DocumentoOrigem : DFeDocument<DocumentoOrigem>
    {
        [DFeItemValue]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "tipo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Tipo { get; set; }
    }
}
