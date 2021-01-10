using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Chain_of_Responsibility.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
