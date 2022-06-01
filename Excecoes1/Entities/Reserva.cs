using System.Collections.Generic;

namespace Excecoes1.Entities
{
    public class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {

        }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return int.Parse(duracao.TotalDays);
        }

        public override string ToString()
        {
            StringBuilder sb = StringBuilder();
            sb.Append($"Númeor do Quarto: {NumeroQuarto}");
            sb.Append($"Data check-in: {CheckIn.ToString("dd/MM/yyyy")}");
            sb.Append($"Data check-out: {CheckOut.ToString("dd/MM/yyyy")}");
            sb.Append($"Reserva: {Duracao()} dias");
            return sb.ToString();
        }
    }
}
