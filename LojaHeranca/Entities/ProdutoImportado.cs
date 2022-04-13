using System.Text;
using System.Globalization;

namespace LojaHeranca.Entities
{
    public class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public override string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} - R${PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }
    }
}