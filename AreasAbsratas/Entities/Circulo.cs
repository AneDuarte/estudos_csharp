using System;
using AreasAbsratas.Entities.Enums;

namespace AreasAbsratas.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
