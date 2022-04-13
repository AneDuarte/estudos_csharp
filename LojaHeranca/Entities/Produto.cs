using System.Text;
using System.Globalization;

namespace LojaHeranca.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} - R${Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}