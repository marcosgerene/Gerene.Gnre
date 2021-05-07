using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TResultLote_GNRE")]
    public sealed class ConsultarLoteResult : DFeDocument<ConsultarLoteResult>
    {
        [DFeElement(TipoCampo.Enum, "ambiente")]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement("situacaoProcess")]
        public Situacao SituacaoProcess { get; set; }

        [DFeElement("resultado")]
        public Resultado Resultado { get; set; }

        public ConsultarLoteResult()
        {
            SituacaoProcess = new Situacao();
            Resultado = new Resultado();
        }
    }
}
