using System.Text;
using Excecoes1.Entities.Exceptions;

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
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de check-out deve ser depois da de check-in.");
            }

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizacaoDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("As reservas devem ser feitas para datas futuras.");
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("A data de check-out deve ser depois da de check-in.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Número do Quarto: {NumeroQuarto} ");
            sb.Append($"Data check-in: {CheckIn.ToString("dd/MM/yyyy")} ");
            sb.Append($"Data check-out: {CheckOut.ToString("dd/MM/yyyy")} ");
            sb.Append($"Reserva: {Duracao()} dias");
            return sb.ToString();
        }
    }
}
