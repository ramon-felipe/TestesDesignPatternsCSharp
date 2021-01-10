using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarManualBuilder : ICarManualBuilder
    {
        public static CarManualBuilder Instance { get; private set; }
        public int NumPages { get; private set; }
        public string ManualVersion { get; private set; }


        private CarManualBuilder()
        {

        }

        public static CarManualBuilder GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CarManualBuilder();
            }

            return Instance;
        }

        public CarManual Build()
        {
            return new CarManual(NumPages, ManualVersion);
        }

        public CarManualBuilder SetManualVersion(string version)
        {
            ManualVersion = version;

            return this;
        }

        public CarManualBuilder SetNumPages(int numPages)
        {
            NumPages = numPages;

            return this;
        }
    }
}
