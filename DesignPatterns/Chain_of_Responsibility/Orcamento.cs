using System;
using System.Collections.Generic;
using System.Text;
using TesteDesignPatterns_Chain_of_Responsibility;
using System.Linq;

namespace TesteDesignPatterns_Chain_of_Responsibility
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(IList<Item> itens)
        {
            Itens = itens;
            Valor = SetTotalItensValue();
        }
        
        private double SetTotalItensValue()
        {
            if(Itens.Count > 0)
            {
                return Itens.Sum(i => i.Valor);
            }

            return 0;
        }
    }
}
