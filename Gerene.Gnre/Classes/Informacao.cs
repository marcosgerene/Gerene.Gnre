using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    public sealed class Informacao
    {
        [DFeItemValue(Tipo = TipoCampo.Str)]
        public string Value { get; set; }
    }
}
