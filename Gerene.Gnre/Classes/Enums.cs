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
        Producao = 1,
        Homologacao = 2
    }

    public enum VersaoDados
    {
        Versao1 = 1,
        Versao2 = 2
    }

    public enum SituacaoGuia
    {
        ProcessadaComSucesso = 0,
        InvalidadaPeloPortal = 1,
        InvalidadaPelaUf = 2,
        ErroComunicaao = 3,
        PendenciaProcessamento = 4
    }

    public enum SimNao
    {
        S,
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

}
