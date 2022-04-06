using System;
using System.Globalization;

namespace Vetores{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite a quantidade de pessoas: ");
            int qtd = int.Parse(Console.ReadLine());

            double[] vetor = new double[qtd];
            double soma = 0;

            for(int i = 0; i < qtd; i++){
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            double media = (soma / qtd);
            Console.WriteLine($"A média de altura é {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}