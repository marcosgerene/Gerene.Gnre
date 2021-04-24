using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    [DFeRoot("TConsLote_GNRE", Namespace = "http://www.gnre.pe.gov.br")]
    public sealed class ConsultaLoteRequest : DFeDocument<ConsultaLoteRequest>
    {
        [DFeIgnore]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Int, "ambiente")]
        public int AmbienteProxy
        {
            get => Convert.ToInt32(Ambiente);
            set => Ambiente = (TipoAmbiente)value;
        }

        [DFeElement(TipoCampo.Str, "numeroRecibo")]
        public string NumeroRecibo { get; set; }

        [DFeIgnore]
        public string IncluirPdfsGuiasProxy
        {
            get => IncluirPdfsGuias ? "S" : "N";
            set => IncluirPdfsGuias = value == "S" ? true : value == "N" ? false : throw new ArgumentException($"IncluirPdfsGuias - \"{value}\"");
        }

        [DFeElement(TipoCampo.Str, "incluirPDFGuias")]
        public bool IncluirPdfsGuias { get; set; }        
    }
}
 