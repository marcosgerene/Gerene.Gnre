using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    public sealed class Recibo : DFeDocument<Recibo>
    {
        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.DatHor, "dataHoraRecibo")]
        public DateTime DataHoraRecibo { get; set; }

        [DFeElement(TipoCampo.Int, "tempoEstimadoProc")]
        public int TempoEstimadoProc { get; set; }
    }
}
