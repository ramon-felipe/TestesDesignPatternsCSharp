using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Chain_of_Responsibility.Descontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
