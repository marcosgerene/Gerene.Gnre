using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.Gnre.Classes
{
    public sealed class IdContribuinte : DFeDocument<IdContribuinte>
    {
        [DFeElement(TipoCampo.Str, "CNPJ", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Cnpj { get; set; }

        [DFeElement(TipoCampo.Str, "CPF", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Cpf { get; set; }
    }
}
