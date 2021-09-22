using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TRetLote_GNRE")]
    public sealed class RecepcaoLoteResult : DFeDocument<RecepcaoLoteResult>
    {
        [DFeElement(TipoCampo.Enum, "ambiente")]
        public TipoAmbiente Ambiente { get; set; }

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
