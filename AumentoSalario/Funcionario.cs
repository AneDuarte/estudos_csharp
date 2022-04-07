using System.Globalization;

namespace AumentoSalario
{
    public class Funcionario
    {
        //public List<Funcionario> Funcionarios { get; set; }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double perc)
        {
            Salario += Salario * (perc / 100);
        }

        public override string ToString()
        {
            return $"Id {Id}, Nome: {Nome}, Salário atual {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}