using Gerene.Gnre.Classes;
using Gerene.Gnre.WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerene.Gnre.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GnreClient().ConfigUf("RN", "100102");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string document = File.ReadAllText(@"D:\Desenvolvimento\Fontes\Gerene.GNRe\Gerene.Gnre.Demo\bin\Debug\net5.0-windows\gnre\2021042449870_ConfigUfEnvio_ret.xml", Encoding.UTF8);

            var result = ConsultaConfigUfResult.Load(document);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dadosDifal = new DadosGnreRequest(VersaoDados.Versao1)
            {
                UfFavorecida = "MG",
                Receita = "100102",
                TipoIdentificacaoEmitente = TipoIdentificacao.Cnpj,
                IdContribuinteEmitente = new IdContribuinte() { Cnpj = "26363645000182" },
                TipoDocOrigem = "10",
                DocOrigem = "11111",
                ValorPrincipal = 4.65M,
                DataVencimento = DateTime.Today,
                RazaoSocialEmitente = "Marcos Gerene Felix Spirito - ME",
                EnderecoEmitente = "Rua XV de Novembro, 196",
                MunicipioEmitente = 14106,
                UfEnderecoEmitente = "SP",
                CepEmitente = "17300000",
                TelefoneEmitente = "1436550203",
                DataPagamento = DateTime.Today
            };

            var dadosFcp = new DadosGnreRequest(VersaoDados.Versao1)
            {
                UfFavorecida = "MG",
                Receita = "100129",
                //DetalhamentoReceita = "000051",
                TipoIdentificacaoEmitente = TipoIdentificacao.Cnpj,
                IdContribuinteEmitente = new IdContribuinte() { Cnpj = "26363645000182" },
                TipoDocOrigem = "10",
                DocOrigem = "1111",
                ValorPrincipal = 4.65M,
                DataVencimento = DateTime.Today,
                RazaoSocialEmitente = "Marcos Gerene Felix Spirito - ME",
                EnderecoEmitente = "Rua XV de Novembro, 196",
                MunicipioEmitente = 14106,
                UfEnderecoEmitente = "SP",
                CepEmitente = "17300000",
                TelefoneEmitente = "1436550203",
                DataPagamento = DateTime.Today
            };

            var lote = new LoteGnreRequest();
            lote.Guias.DadosGnre.Add(dadosDifal);
            lote.Guias.DadosGnre.Add(dadosFcp);

            var result = new GnreClient().RecepcaoLote(lote);
            MessageBox.Show(result.Recibo.Numero);
        }
    }
}
