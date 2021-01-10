using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (null == OutroImposto) return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
