using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Diretor d = new Diretor();
            var car1 = d.BuildCar("blue");
            var car2 = d.BuildCar("green");
            var cm1 = d.BuildCarManual();

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(cm1);
        }
    }
}
