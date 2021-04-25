using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class Referencia : DFeDocument<Referencia>
    {
        [DFeElement(TipoCampo.Str, "periodo", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 1)]
        public string Periodo { get; set; }

        [DFeIgnore]
        public int Mes { get; set; }

        [DFeElement(TipoCampo.Str, "mes", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public string MesProxy
        {
            get => Mes.ToString("00");
            set => Mes = int.Parse(value);
        }

        [DFeIgnore]
        public int Ano { get; set; }

        [DFeElement(TipoCampo.Str, "ano", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public string AnoProxy
        {
            get => Ano.ToString("0000");
            set => Ano = int.Parse(value);
        }

        [DFeElement(TipoCampo.Str, "parcela", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 4)]
        public string Parcela { get; set; }
    }
}
