using System.Text;
using System.Globalization;

namespace LojaHeranca.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateOnly DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateOnly dataFabricacao)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} - R${Preco.ToString("F2", CultureInfo.InvariantCulture)} - {DataFabricacao}");
            return sb.ToString();
        }
    }
}