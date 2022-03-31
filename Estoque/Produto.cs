using System.Globalization;

namespace Estoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int a)
        {
            Quantidade += a;
        }
        public void RemoverProdutos(int r)
        {
            Quantidade -= r;
        }

        public override string ToString()
        {
            String s = String.Format($"Dados do produto: {this.Nome}, R$ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades. Total R$ {this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
            return s;
        }
    }
}