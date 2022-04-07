using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;

        }

        public void AdicionarContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Receita(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HorasContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}