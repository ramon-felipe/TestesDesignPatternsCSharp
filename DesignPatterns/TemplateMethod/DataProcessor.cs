using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class DataProcessor
    {
        public DataProcessor()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();

        public void SaveData()
        {
            Console.WriteLine("Saving data...");
        }
    }
}
