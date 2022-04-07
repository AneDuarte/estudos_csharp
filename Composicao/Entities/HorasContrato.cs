using System.Collections.Generic;
namespace Composicao.Entities
{
    public class HorasContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HorasContrato()
        {

        }

        public HorasContrato(DateTime data, double valorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}