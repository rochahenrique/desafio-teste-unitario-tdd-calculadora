# DIO - Desafio de Projeto

## Descrição

Desafio de Projeto do Bootcamp WEX - Desenvolvimento .NET e QA.

Esse desafio de projeto consiste em implementar uma calculadora e seus métodos usando a abordagem TDD (_Test Driven Development_).

O sistema possui dois projetos: um do tipo console e um do tipo testes com **xUnit**. O projeto do tipo console possui uma classe em que são realizadas as lógicas principais: **CalculadoraImp**. Essa classe contém métodos que consistem de operações aritméticas básicas bem como a apresentação do histórico das últimas três operações efetuadas. O projeto de testes possui a classe de teste **CalculadoraTests**, assim como os métodos para validar o projeto do tipo console.

O projeto foi desenvolvido usando .NET 6.0 e Visual Studio Code foi utilizado como IDE.

## Projeto Console, suas classes e métodos

Essas são as classes do projeto console, onde fica a principal lógica do sistema.

**Classe CalculadoraImp**

Classe responsável por realizar operações similares a uma calculadora.

| Classe         | Método           | Objetivo                                                                      |
| -------------- | ---------------- | ----------------------------------------------------------------------------- |
| CalculadoraImp | Somar            | Recebe dois números inteiros e retorna a soma como resultado.                 |
| CalculadoraImp | Subtrair         | Recebe dois números inteiros e retorna a diferença entre eles como resultado. |
| CalculadoraImp | Multiplicar      | Recebe dois números inteiros e retorna o produto entre eles como resultado.   |
| CalculadoraImp | Dividir          | Recebe dois números inteiros e retorna a divisão entre eles como resultado.   |
| CalculadoraImp | MostrarHistorico | Retorna uma lista dos resultados das últimas três operações realizadas.       |

## Projeto do tipo teste, suas classes e métodos

**Classe CalculadoraTests**

Classe responsável por realizar os testes da classe CalculadoraImp.

| Classe           | Método de teste   | Resultado esperado do teste                                                                                                                 |
| ---------------- | ----------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| CalculadoraTests | TesteSomar        | Ao passar dois valores inteiros a chamada ao método retorna a soma e o teste retorna verdadeiro.                                            |
| CalculadoraTests | TesteSubtrair     | Ao passar dois valores inteiros a chamada ao método retorna a diferença e o teste retorna verdadeiro.                                       |
| CalculadoraTests | TesteMultiplicar  | Ao passar dois valores inteiros a chamada ao método retorna o produto e o teste retorna verdadeiro.                                         |
| CalculadoraTests | TesteDividir      | Ao passar dois valores inteiros a chamada ao método retorna a divisão inteira e o teste retorna verdadeiro.                                 |
| CalculadoraTests | TestarDivisaoZero | Ao passar dois valores inteiros,dentre eles o zero como divisor, a chamada retorna uma Exception e o teste retorna verdadeiro.              |
| CalculadoraTests | TestarHistorico   | Realiza quatro operações, verifica que o histórico não está vazio e verifica que o tamanho do histórico é três. O teste retorna verdadeiro. |

## Estrutura do projeto

O projeto está estruturado da seguinte maneira:

![Diagrama de Classes](img/diagrama_projeto.png)
