using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class CampoAdicionalCodigo
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Campo { get; set; }
    }

    public sealed class CampoAdicionalTipo
    {
        [DFeItemValue(Tipo = TipoCampo.Enum)]
        public TipoCampoAdicional Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "campo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Campo { get; set; }
    }

    public sealed class CampoAdicional : DFeDocument<CampoAdicional>
    {
        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Enum, "obrigatorio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Obrigatorio { get; set; }

        [DFeElement("codigo")]
        public CampoAdicionalCodigo Codigo { get; set; }

        [DFeElement("tipo")]
        public CampoAdicionalTipo Tipo { get; set; }

        [DFeElement(TipoCampo.Int, "tamanho")]
        public int Tamanho { get; set; }

        [DFeElement(TipoCampo.Int, "casasDecimais")]
        public int CasasDecimais { get; set; }

        [DFeElement(TipoCampo.Str, "titulo")]
        public string Titulo { get; set; }

        [DFeElement("versoesXmlCampoAdicional")]
        public VersoesXml VersoesXmlCampoAdicional { get; set; }

        public CampoAdicional()
        {
            VersoesXmlCampoAdicional = new VersoesXml();
        }
    }
}
