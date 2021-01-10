using System;
using TestesProject.FactoryMethod;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o 1º numero:");
            var result = double.TryParse(Console.ReadLine(), out double n1);
            if (!result)
                Console.WriteLine("Apenas numero");

            Console.WriteLine("Informe o 2º numero:");
            result = double.TryParse(Console.ReadLine(), out double n2);
            if (!result)
                Console.WriteLine("Apenas numero");

            CalculateFactory calcFactory = new CalculateFactory();
            Console.WriteLine("Informe a operação: add, sub or div. Type exit to exit");
            var input = Console.ReadLine();

            if (input.ToLower().Equals("exit")) return;

            ICalculate obj = calcFactory.GetCalculation(input);
            if (obj != null)
                obj.Calculate(n1, n2);

            Main();
        }
    }
}
