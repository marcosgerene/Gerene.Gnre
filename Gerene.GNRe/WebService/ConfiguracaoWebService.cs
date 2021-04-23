using Gerene.GNRe.Classes;

namespace Gerene.GNRe.WebService
{
    public sealed class ConfiguracaoWebService
    {
        public VersaoDados VersaoDados => VersaoDados.Versao2;

        public bool ValidarCertificado { get; set; }

        public int Timeout { get; set; }
        public bool SalvarXmls { get; set; }
        public bool SalvarSoap { get; set; }
        public string PathXmls { get; set; }

        public string XmlEnvio { get; private set; }
        public string XmlResposta { get; private set; }

    }
}
