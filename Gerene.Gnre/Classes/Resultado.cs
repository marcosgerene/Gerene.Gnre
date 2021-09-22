using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using System;
using System.Collections.Generic;

namespace Gerene.Gnre.Classes
{
    public sealed class Resultado : DFeDocument<Resultado>
    {
        [DFeCollection("guia")]
        public List<GuiaResult> Guia { get; set; }

        [DFeElement("pdfGuias")]
        public string PdfGuiasProxy { get; set; }

        [DFeIgnore]
        public byte[] PdfGuias => PdfGuiasProxy.IsNull() ? null : Convert.FromBase64String(PdfGuiasProxy);

        public Resultado()
        {
            Guia = new List<GuiaResult>();
        }

    }
}
