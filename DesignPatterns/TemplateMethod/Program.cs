using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProcessor excel = new ExcelFile();
            DataProcessor text = new TextFile();

            ExcelFile excel2 = new ExcelFile();

            excel.ReadData();
            excel2.ReadData();
        }
    }
}
