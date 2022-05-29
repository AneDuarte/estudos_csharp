using System;
using AreasAbsratas.Entities;
using AreasAbsratas.Entities.Enums;
using System.Globalization;

namespace AreasAbsratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> lista = new List<Forma>();

            Console.WriteLine("Digite a quantidade de formas geométricas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da {i}° figura: ");
                Console.WriteLine("Retangulo ou circulo? (r/c) ");
                char resp = char.Parse(Console.ReadLine());

                Console.WriteLine("Qual a cor? Preto/Azul/Vermelho ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (resp == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Alura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Radio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new Circulo(raio, cor));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Áreas das formas geométricas: ");

            foreach (Forma forma in lista)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}