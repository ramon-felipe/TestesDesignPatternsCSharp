using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
