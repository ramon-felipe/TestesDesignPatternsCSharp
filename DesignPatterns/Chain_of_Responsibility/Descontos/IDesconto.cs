using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Chain_of_Responsibility.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto ProximoDesconto { get; set; }
    }
}
