using Gerene.GNRe.Classes;

namespace Gerene.GNRe.WebService
{
    public sealed class ConfiguracaoCertificado
    {
        public TipoCertificado Tipo { get; set; }
        public string Serial { get; set; }
        public string Senha { get; set; }
        public string Path { get; set; }
        public byte[] ArrayBytes { get; set; }        
    }
}
