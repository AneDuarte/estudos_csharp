using System;
using System.Globalization;


namespace ConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            ConversorMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            ConversorMoeda.QtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O valor a ser pago em reais é {ConversorMoeda.Total()}");
        }
    }
}