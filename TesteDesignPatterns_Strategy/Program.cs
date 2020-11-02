using System;

namespace TesteDesignPatterns_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto cofins = new COFINS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, cofins);

            Console.ReadKey();
        }
    }
}
