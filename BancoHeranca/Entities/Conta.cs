namespace BancoHeranca.Entities
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}