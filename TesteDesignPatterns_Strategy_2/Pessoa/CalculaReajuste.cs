using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDesignPatterns_Strategy_2.Pessoa
{
    public class CalculaReajuste
    {
        public double ObtemReajuste(Salario salario, IPessoa pessoa)
        {
            return pessoa.ObtemReajusteSalario(salario);
        }
    }
}
