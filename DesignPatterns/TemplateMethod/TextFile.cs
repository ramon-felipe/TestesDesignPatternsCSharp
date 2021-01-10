using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading Text Data...");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Processing Text Data...");
        }

    }
}
