using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Gerene.Gnre.Classes
{
    public class DecimalCampo : DFeDocument<DecimalCampo>
    {
        [DFeItemValue]
        public decimal Value { get; set; }

        [DFeAttribute(TipoCampo.Str, "tipo")]
        public string Tipo { get; set; }
    }

    public sealed class ItemGnre : DFeDocument<ItemGnre>
    {
        [DFeElement(TipoCampo.Str, "receita", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 1)]
        public string Receita { get; set; }

        [DFeElement(TipoCampo.Str, "detalhamentoReceita", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public string DetalhamentoReceita { get; set; }

        [DFeElement(TipoCampo.Str, "documentoOrigem", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public DocumentoOrigem DocumentoOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "produto", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 4)]
        public string Produto { get; set; }

        [DFeElement("referencia", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 5)]
        public Referencia Referencia { get; set; }

        [DFeElement(TipoCampo.Dat, "dataVencimento", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 6)]
        public DateTime? DataVencimento { get; set; }

        [DFeCollection("valor", Tipo = TipoCampo.De2, Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 7)]
        public List<DecimalCampo> Valor { get; set; }

        [DFeElement(TipoCampo.Str, "convenio", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 8)]
        public string Convenio { get; set; }

        [DFeElement("contribuinteDestinatario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 9)]
        public ContribuinteDestinatario ContribuinteDestinatario { get; set; }

        [DFeElement("camposExtras", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 10)]
        public CamposExtras2 CamposExtras { get; set; }

        [DFeElement(TipoCampo.Str, "numeroControle", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 11)]
        public string NumeroControle { get; set; }

        [DFeElement(TipoCampo.Str, "numeroControleFecp", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 12)]
        public string NumeroControleFecp { get; set; }
    }
}
