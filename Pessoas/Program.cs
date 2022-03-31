using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome, a idade e o salário da primeira pessoa.");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());
            p1.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome, a idade e o salário da segunda pessoa.");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());
            p2.Salario = float.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p1.Nome);
            }
            else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p2.Nome);
            }
            else
            {
                Console.WriteLine("Ambos tem a mesma idade.");
            }

            Console.WriteLine("");
            Console.WriteLine($"A média salarial de {p1.Nome} e {p2.Nome} é {(p1.Salario + p2.Salario) / 2}");

        }
    }
}