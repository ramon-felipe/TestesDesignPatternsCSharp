using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Impostos
{
    public class COFINS : Imposto
    {
        public COFINS() { }
        public COFINS(Imposto outroImposto): base(outroImposto) {}

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoOutroImposto(orcamento);
        }
    }
}
