using Excecoes1.Entities;
using Excecoes1.Entities.Exceptions;

namespace Excecoes1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data check-in: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data check-out: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numQuarto, checkin, checkout);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Dados de atualização de reserva: ");
                Console.Write("Data check-in: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data check-out: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.AtualizacaoDatas(checkin, checkout);
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}