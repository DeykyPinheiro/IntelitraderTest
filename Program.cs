// See https://aka.ms/new-console-template for more information

using System.Globalization;
using IntelitraderTest.Distancia;
using IntelitraderTest.Ofertas;

// =============================================PRIMEIRA MAIN=======================================================

OperacaoFactory LivroDeOperacoes = new OperacaoFactory();


Console.WriteLine($"Digite quantas linhas serao inseridas: ");
int entradas = int.Parse(Console.ReadLine());

int i = 0;
while (i < entradas)
{

    Console.WriteLine($"Digite entrada {i + 1}: ");
    string[] dados = Console.ReadLine().Split(',');

    int posicao = int.Parse(dados[0]);
    int acao = int.Parse(dados[1]);
    double valores = Convert.ToDouble(dados[2], CultureInfo.InvariantCulture);
    int quantidade = int.Parse(dados[3]);

    Operacao NovaOperacao = new Operacao(posicao, acao, valores, quantidade);
    LivroDeOperacoes.NovaOperacao(NovaOperacao);

    i++;
}

Console.WriteLine($"==========Resultado==========");
LivroDeOperacoes.ExibirOperacoes();


// =============================================SEGUNDA MAIN=======================================================
// int[] array1 = { -1, 5 };
// int[] array2 = { 26, 6 };
// Distancia distancia = new Distancia();
// int menorDistancia = distancia.MenorDistancia(array1, array2);

// Console.WriteLine($"menor distancia: {menorDistancia}");