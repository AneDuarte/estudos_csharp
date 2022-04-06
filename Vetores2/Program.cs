using System;
using System.Globalization;

namespace Vetores2{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine("Qual a quantidade de produtos? ");
            int resp = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[resp];
            double soma = 0;

            for(int i = 0; i < resp; i++){
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produto{Nome = nome, Preco = preco};

                soma += vetor[i].Preco;
            }

            double media = soma / resp;

            Console.WriteLine($"A média de preço dos produtos é R${media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}