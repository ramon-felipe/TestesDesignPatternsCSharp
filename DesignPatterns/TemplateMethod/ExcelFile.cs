using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ExcelFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading Excel Data...");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Processing Excel Data...");
        }

    }
}
