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
        [DFeElement(TipoCampo.Enum, "ambiente")]
        public TipoAmbiente Ambiente { get; set; }

        [DFeElement(TipoCampo.Str, "numeroRecibo")]
        public string NumeroRecibo { get; set; }

        
        [DFeElement(TipoCampo.Str, "incluirPDFGuias")]
        public string IncluirPdfsGuiasProxy
        {
            get => IncluirPdfsGuias ? "S" : "N";
            set => IncluirPdfsGuias = value == "S" || (value == "N" ? false : throw new ArgumentException($"IncluirPdfsGuias - \"{value}\""));
        }

        [DFeIgnore]
        public bool IncluirPdfsGuias { get; set; }        
    }
}
 