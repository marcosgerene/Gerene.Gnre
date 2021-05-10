using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class SimNaoCampo
    {
        [DFeItemValue(Tipo = TipoCampo.Enum)]
        public SimNao? Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }
    }

    [DFeRoot("TConfigUf", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class ConsultaConfigUfResult : DFeDocument<ConsultaConfigUfResult>
    {
        [DFeElement(TipoCampo.Enum, "ambiente")]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Str, "uf")]
        public string Uf { get; set; }

        [DFeElement("situacaoConsulta")]
        public Situacao SituacaoConsulta { get; set; }

        [DFeElement(TipoCampo.Enum, "exigeUfFavorecida", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeUfFavorecida { get; set; }

        [DFeAttribute(TipoCampo.Enum, "exigeReceita", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNaoCampo ExigeReceita { get; set; }

        [DFeCollection("receitas")]
        [DFeItem(typeof(Receita), "receita")]
        public List<Receita> Receitas { get; set; }

        [DFeCollection("versoesXml")]
        [DFeItem(typeof(VersaoXml), "versao")]
        public List<VersaoXml> VersoesXml { get; set; }

        public ConsultaConfigUfResult()
        {
            SituacaoConsulta = new Situacao();
            Receitas = new List<Receita>();
            VersoesXml = new List<VersaoXml>();
        }
    }
}