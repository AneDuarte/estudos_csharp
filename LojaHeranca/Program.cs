using LojaHeranca.Entities;
namespace LojaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> lista = new List<Produto>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("É um produto comum, importado ou usado? (c/i/u) ");
                char resp = char.Parse(Console.ReadLine().ToLower());

                if (resp == 'u')
                {
                    Console.Write("Data fabricação: ");
                    DateOnly dataFabricacao = DateOnly.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else if (resp == 'i')
                {
                    Console.Write("Taxa alfândega: ");
                    double taxaAlf = double.Parse(Console.ReadLine());
                    lista.Add(new ProdutoImportado(nome, preco, taxaAlf));
                }
                else if (resp == 'c')
                {
                    lista.Add(new Produto(nome, preco));

                }
                else
                {
                    Console.WriteLine("Valor iválido.");
                }

            }
        }
    }
}