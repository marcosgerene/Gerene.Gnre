using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;

namespace Gerene.Gnre.Classes
{
    public class DadosGnreRequestVersao2 : DFeDocument<DadosGnreRequestVersao2>
    {
        public DadosGnreRequestVersao2()
        {
        }

        [DFeAttribute(TipoCampo.Str, "versao", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Versao
        {
            get => "2.00";
            set { }
        }

        [DFeElement(TipoCampo.Str, "ufFavorecida", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string UfFavorecida { get; set; }

        [DFeIgnore]
        public TipoGnre? TipoGnre { get; set; }

        [DFeElement(TipoCampo.Int, "tipoGnre", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public int? TipoGnreProxy
        {
            get => TipoGnre.HasValue ? Convert.ToInt32(TipoGnre.Value) : (int?)null;
            set
            {
                if (value.HasValue)
                    TipoGnre = (TipoGnre)value.Value;
                else
                    TipoGnre = null;
            }
        }

        [DFeElement("contribuinteEmitente", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public ContribuinteEmitente IdContribuinteEmitente { get; set; }

        [DFeElement("itensGNRE", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 4)]
        public ItensGnre ItensGnre { get; set; }

        [DFeElement(TipoCampo.De2, "valorGNRE", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 5)]
        public decimal? ValorGnre { get; set; }

        [DFeElement(TipoCampo.Dat, "dataPagamento", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 6)]
        public DateTime? DataPagamento { get; set; }

        [DFeElement(TipoCampo.Str, "identificadorGuia", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 7)]
        public string IdentificadorGuia { get; set; }
    }
}