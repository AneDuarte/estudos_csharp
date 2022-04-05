using System.Globalization;

namespace ContaBancaria
{
    public class Conta
    {
        //Propriedades
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtores
        public Conta()
        {

        }
        public Conta(int numero, string titular)
        {
            NumeroConta = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }

        public override string ToString()
        {
            string s = String.Format($"Numero da conta: {NumeroConta}, Nome do titular: {Titular}, Saldo atual: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            return s;
        }

    }
}