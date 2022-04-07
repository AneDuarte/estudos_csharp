using Composicao.Entities.Enums;
using Composicao.Entities;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();

            Console.WriteLine("Dados do trabalhador.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (1 - Júnior, 2 - Pleno, 3 - Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            //int nivel = int.Parse(Console.ReadLine());

            Console.Write("Salário base: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciar objetos
            Departamento dep = new Departamento(nomeDepartamento);
            Trabalhador trab = new Trabalhador(nome, nivel, salario, dep);

            Console.WriteLine("Quantos contratos terá esse trabalhador? ");
            int qtdContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContratos; i++)
            {
                Console.WriteLine($"Digite os dados do {i}° contrato: ");
                Console.Write("Data: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());

                HorasContrato contrato = new HorasContrato(data, valorHora, horas);
                trab.AdicionarContrato(contrato);
            }

            Console.Write("Digite o mês e ano para calcular o valor da receita (MM/AAAA): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {trab.Nome}");
            Console.WriteLine($"Departamento: {trab.Departamento.Nome}");

            Console.WriteLine($"Receita para {mesAno}: {trab.Receita(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}