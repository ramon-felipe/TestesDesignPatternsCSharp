using System;
using TestesProject.FactoryMethod;
using TestesProject.TemplateMethod;

namespace TestesProject
{
    class Program
    {
        static void Main()
        {

            //SingletonTest();
            //FactoryMethodTest();
            TemplateMethodTest();
            Console.ReadKey();
        }

        private static void TemplateMethodTest()
        {
            DataProcessor excel = new ExcelFile();
            DataProcessor text = new TextFile();

            ExcelFile excel2 = new ExcelFile();

            excel.ReadData();
            excel2.ReadData();
            
        }

        private static void FactoryMethodTest()
        {
            double n1, n2;
            Console.WriteLine("Informe o 1º numero:");
            var result = double.TryParse(Console.ReadLine(), out n1);
            if (!result)
                Console.WriteLine("Apenas numero");

            Console.WriteLine("Informe o 2º numero:");
            result = double.TryParse(Console.ReadLine(), out n2);
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

        private static void SingletonTest()
        {
            var s = TesteSingleton.GetInstance();
            var s2 = TesteSingleton.GetInstance();
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            s.ShowMessage();
            s2.ShowMessage();
            var a = TesteSingleton.Instance2;
            Console.WriteLine(a.GetHashCode());
            a.ShowMessage();

            //Console.WriteLine(s3.GetHashCode());
        }

    }

}
