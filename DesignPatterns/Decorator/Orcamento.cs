using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
