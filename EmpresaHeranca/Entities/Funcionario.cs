using System.Text;

namespace EmpresaHeranca.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} - R$ {Pagamento()},00");
            return sb.ToString();
        }
    }
}