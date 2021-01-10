using System;
using System.Collections.Generic;
using TesteDesignPatterns_Chain_of_Responsibility.Descontos;

namespace TesteDesignPatterns_Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            IList<Item> Itens = new List<Item>()
            {
                new Item("CANETA", 500),
                new Item("LAPIS", 300),
                new Item("LAPIS", 300),
                new Item("LAPIS", 300)
            };
            
            Orcamento orcamento = new Orcamento(Itens);

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
