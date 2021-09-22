using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class StringCampo
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Campo { get; set; }
    }

    public sealed class TipoCampoAdicionalTipo
    {
        [DFeItemValue(Tipo = TipoCampo.Enum)]
        public TipoCampoAdicional Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Campo { get; set; }
    }

    public sealed class CampoAdicional
    {
        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Enum, "obrigatorio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Obrigatorio { get; set; }

        [DFeElement("codigo")]
        public StringCampo Codigo { get; set; }

        [DFeElement("tipo")]
        public TipoCampoAdicionalTipo Tipo { get; set; }

        [DFeElement(TipoCampo.Int, "tamanho")]
        public int Tamanho { get; set; }

        [DFeElement(TipoCampo.Int, "casasDecimais")]
        public int CasasDecimais { get; set; }

        [DFeElement(TipoCampo.Str, "titulo")]
        public string Titulo { get; set; }

        [DFeCollection("versoesXmlCampoAdicional")]
        [DFeItem(typeof(VersaoXml), "versao")]
        public List<VersaoXml> VersoesXml { get; set; }

        public CampoAdicional()
        {
            VersoesXml = new List<VersaoXml>();
        }
    }
}
