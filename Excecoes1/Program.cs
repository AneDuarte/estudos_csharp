using Excecoes1.Entities;

namespace Excecoes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do quarto: ");
            int numQuarto = int.Parse(Console.ReadLine());

            Console.Write("Data check-in: ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Data check-out: ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reserva reserva = Reserva(numQuarto, checkin, checkout);
        }
    }
}