using System;
using System.Threading;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual opção de contagem de tempo você prefere? Segundos ou minutos?");
            Console.WriteLine("Exemplo de segundo: 10s");
            Console.WriteLine("Exemplo de minuto: 3m");
            Console.WriteLine("");
            Console.WriteLine("Para sair digite 00");

            string resposta = Console.ReadLine().ToLower();
            char tipo = char.Parse(resposta.Substring(resposta.Length - 1, 1));
            int tempo = int.Parse(resposta.Substring(0, resposta.Length - 1));

            // Console.WriteLine(tipo);
            // Console.WriteLine(tempo);

            if (tipo == 'm')
            {
                tempo = tempo * 60;
            }
            if (tempo == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(tempo);

        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(tempo);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}