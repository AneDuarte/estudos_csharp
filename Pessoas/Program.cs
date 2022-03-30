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

            Console.WriteLine("Digite o nome e idade da primeira pessoa.");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e idade da segunda pessoa.");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p1.nome);
            }
            else if (p2.idade > p1.idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p2.nome);
            }
            else
            {
                Console.WriteLine("Ambos tem a mesma idade.");
            }

        }
    }
}