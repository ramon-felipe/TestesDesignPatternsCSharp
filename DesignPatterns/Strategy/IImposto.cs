using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
