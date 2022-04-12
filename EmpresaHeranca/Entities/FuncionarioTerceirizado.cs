using System.Text;

namespace EmpresaHeranca.Entities
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double ValorAdicional { get; set; }

        public FuncionarioTerceirizado()
        {

        }

        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double valorAdicional) : base(nome, horas, valorHora)
        {
            ValorAdicional = valorAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + ValorAdicional * 1.1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} - R$ {Pagamento()},00");
            return sb.ToString();
        }
    }
}