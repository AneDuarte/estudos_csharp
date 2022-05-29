using System;
using AreasAbsratas.Entities.Enums;

namespace AreasAbsratas.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }
    }
}
