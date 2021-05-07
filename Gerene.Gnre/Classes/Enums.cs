using ACBr.Net.DFe.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.Gnre.Classes
{
    public enum TipoCertificado
    {
        Nenhum,
        A1Repositorio,
        A1Arquivo,
        A1ByteArray,
        A3
    }

    public enum TipoAmbiente
    {
        [DFeEnum("1")]
        Producao = 1,
        [DFeEnum("2")]
        Homologacao = 2
    }

    public enum VersaoDados
    {
        Versao1 = 1,
        Versao2 = 2
    }

    public enum SituacaoGuia
    {
        [DFeEnum("0")]
        ProcessadaComSucesso = 0,
        [DFeEnum("1")]
        InvalidadaPeloPortal = 1,
        [DFeEnum("2")]
        InvalidadaPelaUf = 2,
        [DFeEnum("3")]
        ErroComunicaao = 3,
        [DFeEnum("4")]
        PendenciaProcessamento = 4
    }

    public enum SimNao
    {
        [DFeEnum("S")]
        S,
        [DFeEnum("N")]
        N
    }

    public enum ValorExigido
    {
        P,
        T,
        A,
        PO,
        TO,
        AO,
        N
    }

    public enum TipoCampoAdicional
    {
        T,
        N,
        D
    }

    public enum TipoIdentificacao
    {
        Cnpj = 1,
        Cpf = 2
    }

    public enum TipoCampoExtra
    {
        T,
        N,
        D
    }

    public enum TipoGnre
    {
        GnreSimples = 0,
        GnreMultiplosDoctos = 1,
        GnreMultiplasReceitas = 2
    }

}
