using System;
using System.Globalization;

namespace Empresa
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(float pct)
        {
            SalarioBruto = SalarioBruto + SalarioBruto * (pct / 100);
        }

        public override string ToString()
        {
            String s = String.Format($"Funcionário: {Nome}, Salário: R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
            return s;
        }
    }
}