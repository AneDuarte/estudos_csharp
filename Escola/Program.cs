using System;
using System.Globalization;

namespace Escola
{
    class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno e suas 3 notas: ");
            aluno.Nome = Console.ReadLine();
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"A média do aluno foi {aluno.Media().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(aluno.Aprovacao());

        }
    }
}