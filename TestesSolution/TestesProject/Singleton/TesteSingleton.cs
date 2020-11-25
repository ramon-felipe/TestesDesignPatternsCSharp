using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestesProject
{
    public class TesteSingleton
    {
        private static TesteSingleton Instance { get; set; }
        public static TesteSingleton Instance2
        {
            get
            {
                return GetInstance();
            }
        }

        private TesteSingleton(){}

        public static TesteSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new TesteSingleton();
            }

            return Instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("I'm a singleton");
        }
    }
}
