# Gerene.Gnre

[![Nuget count](http://img.shields.io/nuget/v/Gerene.Gnre.svg)](https://www.nuget.org/packages/Gerene.Gnre)

Projeto para consumo do webservice de Gnre (http://www.gnre.pe.gov.br/gnre/portal/GNRE_Principal.jsp).

O projeto foi desenvolvido em C# .Net Standard 2.0 e conta com um Demo em .Net 5.

Para o consumo do método RecepcaoLote, foi implmentado somente a versão 1.00 (até o momento).

Antes de iniciar
----
Antes de iniciar a implementação da biblioteca:
  * leia a área "Automação" no portal do GNRe 
  * leia o manual que pode ser obtido em: http://www.gnre.pe.gov.br/gnre/portal/arquivos/Manual_de_Integracao_Contribuintes_GNRE_v2.05.zip
  
Outras informações
----
Esse projeto usa como base o projeto ACBr.DFe.Core a serialização dos XMLs e consumo do WebService.
