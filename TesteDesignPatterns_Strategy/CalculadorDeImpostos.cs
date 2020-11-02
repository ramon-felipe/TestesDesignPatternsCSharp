using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Strategy
{
    public class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
