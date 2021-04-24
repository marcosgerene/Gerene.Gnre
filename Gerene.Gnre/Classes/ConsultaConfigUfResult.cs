using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;

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

        [DFeAttribute(TipoCampo.Enum, "exigeUfFavorecida", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeUfFavorecida { get; set; }

        //campo em exigeUfFavorecida

        [DFeAttribute(TipoCampo.Enum, "exigeReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? ExigeReceita { get; set; }

        //campo em exigeReceita 

        [DFeElement("receitas")]
        public Receitas Receitas { get; set; }

        [DFeElement("versoesXml")]
        public VersoesXml VersoesXml { get; set; }

    }
}
