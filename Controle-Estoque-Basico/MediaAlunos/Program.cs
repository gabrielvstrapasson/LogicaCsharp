/*Dictionary<string, List<int>> notasAlunos = new Dictionary<string, List<int>>
{
    { "Gabriel", new List<int> { 10, 5, 8} },
    { "Maria", new List<int> {5, 6, 8} }

};

List<int> notasGabriel = notasAlunos["Gabriel"];
double mediaNotasGabriel = notasGabriel.Average();
Console.WriteLine($"Media {mediaNotasGabriel:F2}");
*/

// Dicionario

using System;
using System.ComponentModel.Design;
using System.Linq;

Dictionary<string, int> estoqueProdutos = new Dictionary<string,int>();
Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Informar Estoque do Produto");
    Console.WriteLine("3 - Verificar Estoque");
    
    int opcaoUsuario = int.Parse(Console.ReadLine()!);  

    switch (opcaoUsuario)
    {
        case 1: CadastrarProduto(); break;
        case 2: CadastrarEstoqueProduto(); break;
        case 3: ImprimirEstoque(); break;
    }
    
}


void CadastrarProduto()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
    string nomeProduto = Console.ReadLine()!;
    estoqueProdutos[nomeProduto] = 0;
    Console.Clear();
    Console.WriteLine("Produto cadastro com sucesso.");
    Thread.Sleep(2000);
    Menu();
}

void CadastrarEstoqueProduto ()
{
    Console.Clear();
    Console.WriteLine("Digite o produto que deseja inserir o estoque: ");
    string produtoUsuario = Console.ReadLine()!;

    if (estoqueProdutos.ContainsKey(produtoUsuario))
        {
        Console.WriteLine("Produto encontrado.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"Informe a quantidade no estoque do {produtoUsuario}: ");
        int quantidadeProduto = int.Parse( Console.ReadLine()!);
        estoqueProdutos[produtoUsuario] += quantidadeProduto;
        Console.WriteLine("Quantidade cadastrada.");
        Thread.Sleep(2000);
        Menu();
    }

    else
    {
        Console.Clear();
        Console.WriteLine($"{produtoUsuario} não encontrado.");
        Thread.Sleep(2000);
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
        Menu();
    }
}

void ImprimirEstoque()
{
    foreach (var item in estoqueProdutos)
    {
        Console.WriteLine($"Produto: {item.Key} \tQuantidade: {item.Value}");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
        Menu();
    }
}
