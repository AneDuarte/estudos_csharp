using System;
using System.Globalization;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário, o salário bruto e o imposto.");
            f.Nome = Console.ReadLine();
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f.ToString());

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            float pct = float.Parse(Console.ReadLine());
            f.AumentarSalario(pct);
            Console.WriteLine(f.ToString());

        }
    }
}