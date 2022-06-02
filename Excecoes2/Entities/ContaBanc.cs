namespace Excecoes2.Entites
{
    public class ContaBanc
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public ContaBanc()
        {

        }

        public ContaBanc(int numero, string titulo, double saldo, double limite)
        {
            Numero = numero;
            Titular = titulo;
            Saldo = saldo;
            Limite = limite;
        }
        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }
    }
}