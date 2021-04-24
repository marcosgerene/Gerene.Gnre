using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class CampoAdicional : DFeDocument<CampoAdicional>
    {
        [DFeAttribute(TipoCampo.Str, "campo")]
        public string Campo { get; set; }

        [DFeAttribute(TipoCampo.Enum, "obrigatorio", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public SimNao? Obrigatorio { get; set; }

        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - codigo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

        [DFeElement(TipoCampo.Enum, "tipo")]
        public TipoCampoAdicional Tipo { get; set; }

        //[DFeAttribute(TipoCampo.Enum, "campo - codigo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        //public string Campo { get; set; }

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
