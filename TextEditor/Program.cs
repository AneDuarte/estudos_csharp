using System;
using System.IO;
using System.Threading;

namespace TextEditor
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
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar arquivo");
            Console.WriteLine("");
            Console.WriteLine("0- Sair da aplicação");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();
            Console.WriteLine("");

            using (var file = new StreamReader(path))
            {
                string content = file.ReadToEnd();
                Console.WriteLine(content);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o conteúdo do texto no espaço abaixo.(ESC para sair).");
            Console.WriteLine("------------------------------------------------------------");

            string content = "";

            do
            {
                content += Console.ReadLine();
                content += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(content);
        }

        static void Salvar(string content)
        {
            Console.Clear();
            Console.WriteLine("Como você quer salvar o arquivo? Digite com todo o path se preferir.");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(content);
            }
            Console.WriteLine("Arquivo salvo com sucesso!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Menu();
        }
    }

}