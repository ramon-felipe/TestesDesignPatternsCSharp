using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Strategy_2.Pessoa
{
    public class Gerente : IPessoa
    {

        public double ObtemReajusteSalario(Salario salario)
        {
            return salario.Valor * 2;
        }
    }
}
