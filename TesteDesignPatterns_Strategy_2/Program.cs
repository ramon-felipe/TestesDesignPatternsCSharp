using System;
using TesteDesignPatterns_Strategy_2.Pessoa;

namespace TesteDesignPatterns_Strategy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new Salario(5000.0);
            var programador = new Programador();
            IPessoa gerente = new Gerente();
            var CalculadorReajuste = new CalculaReajuste();

            Console.WriteLine(CalculadorReajuste.ObtemReajuste(salario, programador));
            Console.WriteLine(CalculadorReajuste.ObtemReajuste(salario, gerente));

            Console.ReadKey();
        }
    }
}
