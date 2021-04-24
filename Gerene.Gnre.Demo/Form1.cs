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
    }
}
