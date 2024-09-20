using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using listprodutos;
//Cria uma nova lista de produtos
List<Produto> produtos = new List<Produto>();

//Adiciona a quantia de produtos desejada na lista
Console.WriteLine("Quantos produtos quer adicionar na lista?");
int numProdutos = int.Parse(Console.ReadLine());
Console.WriteLine($"Adicionando {numProdutos} produtos \n");
for (int i = 0; i < numProdutos; i++)
{
    Console.WriteLine("Nome do produto:");
    string nomeP = Console.ReadLine();
    Console.WriteLine("Preço do produto:");
    double precoP = double.Parse(Console.ReadLine());

    produtos.Add(new Produto(nomeP, precoP));
}
ExibirTotais(produtos);

//Ordena a lista em ordem alfabética
Console.WriteLine("Ordenando a lista em ordem alfabética: ");
var produtosOrdenados = produtos.OrderBy(p => p.Nome).ToList();
foreach (Produto ordenados in produtosOrdenados)
{
    ordenados.Exibir();
}
Console.WriteLine("");


//Mostra os produtos abaixo de R$5
var baratos = produtos.Where(p => p.Preco < 5).ToList();
Console.WriteLine($"Produtos com preço menor que R$5,00: ");
foreach (Produto produto in baratos)
{
    produto.Exibir();
}
Console.WriteLine("");

//Seção para conferir produtos em sua lista
Console.WriteLine("Gostaria de conferir algum produto em sua lista?\n1 - SIM\n2 - NÃO");
int procurar = int.Parse(Console.ReadLine());

if (procurar == 1)
{
    int buscarNovamente = 0;
    do
    {
        Console.WriteLine("Qual produto deseja conferir?");
        string busca = Console.ReadLine();
        var buscar = produtos.Find(x => x.Nome == busca);
        if (buscar != null)
        {
            Console.WriteLine($"O produto {busca} está na sua lista!");
        }
        else
        {
            Console.WriteLine($"O produto {busca} não foi encontrado na sua lista!");
        }

        Console.WriteLine("Deseja procurar outro produto?\n1 - SIM\n2 - NÃO");
        buscarNovamente = int.Parse(Console.ReadLine());
    } while (buscarNovamente != 2);
}
else
{
    Console.WriteLine("Obrigado por utilizar o app!");
}

//Função retorna a lista com todos os produtos, total, media e a quantidade de produtos
static void ExibirTotais(List<Produto> produtos)
{
    foreach (Produto produto in produtos)
    {
        produto.Exibir();
    }

    double soma = produtos.Sum(p => p.Preco);
    double media = produtos.Average(p => p.Preco);
    int contar = produtos.Count;

    Console.WriteLine($"========================================\nPreço total dos produtos: R${soma}");
    Console.WriteLine($"Total de produtos: {contar}");
    Console.WriteLine($"Preço médio dos produtos: R${media}\n========================================\n");

}

