using System;
using System.Globalization;

namespace ConversorDolar
{
    public static class ConversorMoeda
    {
        public static double Cotacao;
        public static double QtdDolares;
        public static double IOF = 0.06;

        public static double Total()
        {
            double conversao = Cotacao * QtdDolares;
            double imposto = conversao * IOF;
            return (conversao + imposto);
        }
    }
}