using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto.");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Dados do produto: {p.Nome}, R$ {p.Preco}, {p.Quantidade} unidades. Total R$ {p.ValorTotalEmEstoque}");
            Console.WriteLine(p.ToString());

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            //Console.WriteLine($"Dados do produto: {p.Nome}, R$ {p.Preco}, {p.Quantidade} unidades. Total R$ {p.ValorTotalEmEstoque}");
            Console.WriteLine(p.ToString());

            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            //Console.WriteLine($"Dados do produto: {p.Nome}, R$ {p.Preco}, {p.Quantidade} unidades. Total R$ {p.ValorTotalEmEstoque}");
            Console.WriteLine(p.ToString());

        }
    }
}