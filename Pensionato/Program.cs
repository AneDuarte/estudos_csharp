using System;
using System.Globalization;

namespace Pensionato{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vetor = new Aluguel[10];

            for(int i = 0; i < n; i++){
                Console.WriteLine($"Aluguel {i+1}");

                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[quarto] = new Aluguel{Nome =  nome, Email = email, Quarto = quarto};

            }

            Console.WriteLine("Quartos ocupados");
            for(int i = 0; i < 10; i++){
                if(vetor[i] != null){
                    Console.WriteLine($"Quarto {i}: {vetor[i]}");
                }
            }
        }
    }
}