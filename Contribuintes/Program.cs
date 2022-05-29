using System;
using Contribuintes.Entities;
using System.Globalization;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();
            double total = 0;

            Console.WriteLine("Digite a quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° contribuinte: ");

                Console.Write("Pessoa física ou jurídica? (f/j) ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new PessoaJuridica(nome, rendaAnual, numeroFuncionarios));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Impostos pagos: ");

            foreach (Contribuinte pessoa in lista)
            {
                Console.WriteLine($"{pessoa.Nome}: R${pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
                total += pessoa.Imposto();
            }

            Console.WriteLine($"Total de imposto: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}