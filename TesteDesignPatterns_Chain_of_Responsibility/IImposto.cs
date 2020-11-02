using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Strategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
