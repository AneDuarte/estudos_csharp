using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial? (s/n) ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {

                Console.WriteLine("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, deposito);

            }
            else if (resposta == 'n' || resposta == 'N')
            {
                conta = new Conta(numero, titular);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
            }

            Console.WriteLine("");
            Console.WriteLine(conta);

            Console.WriteLine("Digite o valor do depósito: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantidade);
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Digite o valor do saque: ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantidade);
            Console.WriteLine(conta.ToString());
        }
    }
}