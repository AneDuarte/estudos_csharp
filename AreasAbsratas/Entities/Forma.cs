using AreasAbsratas.Entities.Enums;

namespace AreasAbsratas.Entities
{
    abstract class Forma
    {
        public Cor Cor { get; set; }

        public Forma()
        {

        }
        public Forma(Cor cor)
        {

        }
        public abstract double Area();

    }
}