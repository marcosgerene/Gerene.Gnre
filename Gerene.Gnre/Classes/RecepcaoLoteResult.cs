using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TRetLote_GNRE")]
    public sealed class RecepcaoLoteResult : DFeDocument<RecepcaoLoteResult>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Int, "ambiente", Ocorrencia = Ocorrencia.Obrigatoria)]
        public int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

        [DFeElement("situacaoRecepcao", Ocorrencia = Ocorrencia.Obrigatoria)]
        public SituacaoRecepcao SituacaoRecepcao { get; set; }

        [DFeElement("recibo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public Recibo Recibo { get; set; }

        public RecepcaoLoteResult()
        {
            SituacaoRecepcao = new SituacaoRecepcao();

            Recibo = new Recibo();
        }
    }
}
