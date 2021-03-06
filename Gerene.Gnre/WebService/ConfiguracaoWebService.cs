using Gerene.Gnre.Classes;

namespace Gerene.Gnre.WebService
{
    public sealed class ConfiguracaoWebService
    {
        public TipoAmbiente Ambiente { get; set; }
       
        public bool ValidarCertificado { get; set; }

        public int Timeout { get; set; }
        public bool SalvarXmls { get; set; }
        public bool SalvarSoap { get; set; }
        public string DiretorioXmls { get; set; }

        public bool ValidarSchemas { get; set; }
        public string DiretorioSchemas { get; set; }
    }

}
