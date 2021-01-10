using Decorator.Impostos;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto ISS = new ISS(new ICMS());
            Orcamento orcamento = new Orcamento(500);

            var valor = ISS.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
