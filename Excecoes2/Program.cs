using System;

namespace Excecoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da conta bancária: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine());

            ContaBanc contaBanc = new ContaBanc(numero, titular, saldo, limite);

            Console.WriteLine();
            Console.Write("Digite a quantidade do depósito: ");
            double quantidade = double.Parse(Console.ReadLine());
            contaBanc.Deposito(quantidade);
            Console.Write("Digite a quantidade do saque: ");
            quantidade = double.Parse(Console.ReadLine());
            contaBanc.Saque(quantidade);

            Console.Write("Saldo atual: " + contaBanc.Saldo);
        }
    }
}