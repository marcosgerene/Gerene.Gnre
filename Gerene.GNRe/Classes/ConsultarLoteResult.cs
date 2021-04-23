using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.GNRe.Classes
{
    [DFeRoot("TResultLote_GNRE")]
    public sealed class ConsultarLoteResult : DFeDocument<ConsultarLoteResult>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Str, "ambiente")]
        internal int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

        [DFeElement("situacaoProcess")]
        public SituacaoProcess SituacaoProcess { get; set; }

        [DFeElement("resultado")]
        public Resultado Resultado { get; set; }
    }
}
