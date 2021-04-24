using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TResultLote_GNRE")]
    public sealed class ConsultarLoteResult : DFeDocument<ConsultarLoteResult>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Int, "ambiente")]
        public int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

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
