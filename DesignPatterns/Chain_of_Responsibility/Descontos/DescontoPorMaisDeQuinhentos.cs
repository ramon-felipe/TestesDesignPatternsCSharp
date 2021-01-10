using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Chain_of_Responsibility.Descontos
{
    class DescontoPorMaisDeQuinhentos : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
