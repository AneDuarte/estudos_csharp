// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");

            char resposta;


            do
            {
                Console.WriteLine("Escolha a operação desejada: ");
                Console.WriteLine("Para adição digite '+'");
                Console.WriteLine("Para subtração digite '-'");
                Console.WriteLine("Para multiplicação digite '*'");
                Console.WriteLine("Para divisão digite '/'");

                char operacao = Console.ReadLine()[0];

                Console.WriteLine("Digite o primeiro valor: ");
                float valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                float valor2 = float.Parse(Console.ReadLine());

                float total = 0;

                switch (operacao)
                {
                    case '+':
                        total = valor1 + valor2;
                        break;
                    case '-':
                        total = valor1 - valor2;
                        break;
                    case '*':
                        total = valor1 * valor2;
                        break;
                    case '/':
                        total = valor1 / valor2;
                        break;

                }
                Console.WriteLine("O resultado do cálculo é: " + total);
                Console.WriteLine("Deseja fazer outra operação? Responda com 's' ou 'n': ");
                resposta = Console.ReadLine()[0];

                if (resposta != 's' && resposta != 'n')
                {
                    Console.WriteLine("Resposta inválida");
                }

            } while (resposta == 's');

        }
    }
}