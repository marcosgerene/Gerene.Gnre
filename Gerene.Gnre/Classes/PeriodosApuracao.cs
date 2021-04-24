﻿using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    public sealed class PeriodosApuracao : DFeDocument<PeriodosApuracao>
    {
        [DFeElement("periodoApuracao")]
        public List<PeriodoApuracao> PeriodoApuracao { get; set; }
    }
}
