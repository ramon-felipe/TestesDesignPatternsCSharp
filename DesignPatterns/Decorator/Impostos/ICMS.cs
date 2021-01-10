using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS() { }
        public ICMS(Imposto outroImposto): base(outroImposto) {}

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoOutroImposto(orcamento);
        }
    }
}
