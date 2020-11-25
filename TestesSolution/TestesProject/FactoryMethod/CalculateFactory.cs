using System;
using System.Collections.Generic;
using System.Text;
using TestesProject.FactoryMethod.Operations;

namespace TestesProject.FactoryMethod
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;

            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("sub"))
            {
                obj = new Subtract();
            }
            else if (type.ToLower().Equals("div"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't have this.");
            }

            return obj;
        }
    }
}
