using System;
using System.Collections.Generic;
using System.Text;

namespace TestesProject.FactoryMethod.Operations
{
    class Subtract : ICalculate
    {
        public void Calculate(double n1, double n2)
        {
            Console.WriteLine("a - b is {0}", n1 - n2);
        }
    }
}
