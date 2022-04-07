using System;
using System.Globalization;
using System.Collections.Generic;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário {i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine("");
            }

            Console.Write("Digite o id do funcionário que receberá o aumento: ");
            int resp = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Funcionario func = funcionarios.Find(x => x.Id == resp);

            Console.Write("Digite a porcentagem do aumento: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(perc);
            Console.WriteLine("");

            Console.WriteLine("Lista de funcionários.");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }

}