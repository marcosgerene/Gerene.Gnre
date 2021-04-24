using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Gerene.Gnre.WebService
{
    //Baseado em CTe.Utils.Validador de DFe.Net
    public sealed class Validador
    {
        private ConfiguracaoWebService ConfiguracaoWebService { get; set; }
        private StringBuilder Falhas { get; set; }

        public Validador(ConfiguracaoWebService configuracao)
        {
            Falhas = new StringBuilder();
            ConfiguracaoWebService = configuracao;
        }

        public void Validar(string xml, string schema)
        {
            if (!Directory.Exists(ConfiguracaoWebService.DiretorioSchemas))
                throw new Exception($"Diretório de Schemas não encontrado: \"{ConfiguracaoWebService.DiretorioSchemas}\"");

            var arquivoSchema = Path.Combine(ConfiguracaoWebService.DiretorioSchemas, schema);

            // Define o tipo de validação
            var cfg = new XmlReaderSettings { ValidationType = ValidationType.Schema };

            // Carrega o arquivo de esquema
            var schemas = new XmlSchemaSet();
            schemas.XmlResolver = new XmlUrlResolver();

            cfg.Schemas = schemas;
            // Quando carregar o eschema, especificar o namespace que ele valida
            // e a localização do arquivo 
            schemas.Add(null, arquivoSchema);
            // Especifica o tratamento de evento para os erros de validacao
            cfg.ValidationEventHandler += ValidationEventHandler;
            // cria um leitor para validação
            var validator = XmlReader.Create(new StringReader(xml), cfg);
            try
            {
                // Faz a leitura de todos os dados XML
                while (validator.Read())
                {
                }
            }
            catch (XmlException err)
            {
                // Um erro ocorre se o documento XML inclui caracteres ilegais
                // ou tags que não estão aninhadas corretamente
                Falhas.AppendLine(err.Message);
                //throw new Exception("Ocorreu o seguinte erro durante a validação XML:" + "\n" + err.Message);
            }
            finally
            {
                validator.Close();
            }

            if (Falhas.Length > 0)
                throw new ArgumentException(Falhas.ToString());
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            Falhas.AppendLine(e.Message);
        }

    }
}
