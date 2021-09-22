using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class ContribuinteEmitente : DFeDocument<ContribuinteEmitente>
    {
        [DFeElement("identificacao", Ordem = 1)]
        public IdContribuinte IdContribuinteEmitente { get; set; }

        [DFeElement(TipoCampo.Str, "razaoSocial", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public string RazaoSocial { get; set; }

        [DFeElement(TipoCampo.Str, "endereco", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public string Endereco { get; set; }

        [DFeElement(TipoCampo.Long, "municipio", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 4, Min = 5, Max = 5)]
        public long? Municipio { get; set; }

        [DFeElement(TipoCampo.Str, "uf", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 5)]
        public string Uf { get; set; }

        [DFeElement(TipoCampo.Str, "cep", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 6)]
        public string Cep { get; set; }

        [DFeElement(TipoCampo.Str, "telefone", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 7)]
        public string Telefone { get; set; }

    }
}
