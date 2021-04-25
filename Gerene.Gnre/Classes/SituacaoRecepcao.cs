using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class SituacaoRecepcao : DFeDocument<SituacaoRecepcao>
    {
        [DFeElement(TipoCampo.Str, "codigo", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "descricao", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Int, "guiaErro", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public int GuiaErro { get; set; }
    }
}
