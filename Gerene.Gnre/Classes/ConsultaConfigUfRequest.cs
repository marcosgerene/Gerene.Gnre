using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TConsultaConfigUf", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class ConsultaConfigUfRequest : DFeDocument<ConsultaConfigUfRequest>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Int, "ambiente")]
        public int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

        [DFeElement(TipoCampo.Str, "uf")]
        public string Uf { get; set; }

        [DFeAttribute(TipoCampo.Enum, "courier", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Courier { get; set; }

        [DFeElement(TipoCampo.Str, "receita")]
        public string Receita { get; set; }
    }
}
