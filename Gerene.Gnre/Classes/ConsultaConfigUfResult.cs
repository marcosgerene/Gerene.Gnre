using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TConsultaConfigUf", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class ConsultaConfigUfResult : DFeDocument<ConsultaConfigUfResult>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Str, "ambiente")]
        public int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

        [DFeElement(TipoCampo.Str, "uf")]
        public string Uf { get; set; }

        [DFeElement("situacaoConsulta")]
        public Situacao SituacaoConsulta { get; set; }

        [DFeAttribute(TipoCampo.Enum, "exigeUfFavorecida")]
        public SimNao ExigeUfFavorecida { get; set; }

        [DFeAttribute(TipoCampo.Enum, "exigeReceita")]
        public SimNao ExigeReceita { get; set; }

        //[DFeElement("receitas")]
        //public List<Receita> Receitas { get; set; }            

    }
}
