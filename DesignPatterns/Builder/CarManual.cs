using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarManual
    {
        public int NumPages { get; private set; }
        public string ManualVersion { get; private set; }

        public CarManual(int numPages, string manualVersion)
        {
            NumPages = numPages;
            ManualVersion = manualVersion;
        }

        public override string ToString()
        {
            return $"Manual versão {ManualVersion} tem {NumPages} páginas";
        }
    }
}
