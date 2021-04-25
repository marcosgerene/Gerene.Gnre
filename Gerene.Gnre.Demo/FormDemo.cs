using ACBr.Net.Core.Extensions;
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
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {
            ComboTipoCertificado.DataSource = Enum.GetValues(typeof(TipoCertificado));
            ComboTipoCertificado.SelectedItem = TipoCertificado.A1Repositorio;
            TextCertificadoSerial.Text = "05d75a9b9829a807";

            ComboAmbiente.DataSource = Enum.GetValues(typeof(TipoAmbiente));
            ComboAmbiente.SelectedItem = TipoAmbiente.Homologacao;
            TextTimeout.Value = 30000;
            CheckSalvarXmls.Checked = true;
            CheckSalvarXmlsSoap.Checked = true;
            CheckValidarCertificado.Checked = true;
            CheckValidarSchemas.Checked = true;

            TextDiretorioSchemas.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Schemas");
            TextDiretorioXmls.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Gnre");
        }

        private string InputBox(string mensagem, string texto = null)
        {
            using (var form = new FormInputBox())
            {
                form.Text = mensagem;
                form.TextBox1.Text = texto ?? string.Empty;
                form.ShowDialog();

                return form.Tag != null ? form.Tag.ToString().Trim() : string.Empty;
            }
        }

        private GnreClient GetClient() =>
        new GnreClient()
        {
            ConfiguracaoCertificado = new ConfiguracaoCertificado()
            {
                Tipo = (TipoCertificado)ComboTipoCertificado.SelectedItem,
                Serial = TextCertificadoSerial.Text,
                Senha = TextCertificadoSenha.Text,
                Path = TextCertificadoCaminho.Text
            },

            ConfiguracaoWebService = new ConfiguracaoWebService()
            {
                Ambiente = (TipoAmbiente)ComboAmbiente.SelectedItem,
                ValidarSchemas = CheckValidarSchemas.Checked,
                DiretorioSchemas = TextDiretorioSchemas.Text,
                ValidarCertificado = CheckValidarCertificado.Checked,
                SalvarXmls = CheckSalvarXmls.Checked,
                SalvarSoap = CheckSalvarXmlsSoap.Checked,
                DiretorioXmls = TextDiretorioXmls.Text,
                Timeout = (int)TextTimeout.Value
            }
        };

        private void BtnRecepcaoLote_Click(object sender, EventArgs e)
        {
            var request = new LoteGnreRequest()
            {
                Versao = "2.00",
                Guias = new GuiasRequest()
            };

            //Substitua os dados para realizar o teste
            var dados = new DadosGnreRequest(VersaoDados.Versao1) //Até o momento só foi implmentado o envio na versão 1.00
            {
                UfFavorecida = "XX",
                Receita = "100102", //100102 - Difal, 100129 - Fcp
                TipoIdentificacaoEmitente = TipoIdentificacao.Cnpj,
                IdContribuinteEmitente = new IdContribuinte() { Cnpj = "00000000000000" },
                TipoDocOrigem = "10", //10 - Documento fiscal eletronico
                DocOrigem = "000000", //Numero do documento
                ValorPrincipal = 0.00M,
                DataVencimento = DateTime.Today,
                RazaoSocialEmitente = "XXXXXXXX",
                EnderecoEmitente = "XXXXXX",
                MunicipioEmitente = 00000,
                UfEnderecoEmitente = "XX",
                CepEmitente = "XXXXXX",
                TelefoneEmitente = "XXXXXX",
                DataPagamento = DateTime.Today
            };
            
            request.Guias.DadosGnre.Add(dados);

            var client = GetClient();

            try
            {
                client.RecepcaoLote(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnResultadoLote_Click(object sender, EventArgs e)
        {
            string recibo = string.Empty;
            recibo = InputBox("Informe o num. do recibo", recibo);
            if (recibo.IsNull())
                return;

            string incluirPdf = "sim";
            incluirPdf = InputBox("Incluir Pdf?", incluirPdf);
            
            var client = GetClient();

            try
            {
                client.ResultadoLote(recibo, incluirPdf.ToLower() == "sim");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnConfiguracaoUf_Click(object sender, EventArgs e)
        {
            string uf = "PR";
            uf = InputBox("Informe a UF", uf);

            if (uf.Length != 2)
                return;

            string receita = "100102";
            receita = InputBox("Informe a receita", receita);
            if (receita.Length != 6)
                return;

            string courier = "N";
            courier = InputBox("Courier", courier);

            var client = GetClient();

            try
            {
                client.ConfigUf(uf, receita, courier == "S" ? (SimNao?)SimNao.S : null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

    }
}
