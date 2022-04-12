using System.Globalization;
using EmpresaHeranca.Entities;

namespace EmpresaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informações do {i}° funcionário: ");
                Console.WriteLine("Terceirizado? (s/n)");
                char resp = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 's')
                {
                    Console.WriteLine("Digite o valor adicional: ");
                    double valorAdc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorH, valorAdc));
                }
                else
                {
                    lista.Add(new Funcionario(nome, horas, valorH));
                }
            }

            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }
        }
    }
}