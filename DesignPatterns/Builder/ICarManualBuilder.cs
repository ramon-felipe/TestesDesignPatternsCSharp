using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICarManualBuilder
    {
        CarManualBuilder SetNumPages(int numPages);
        CarManualBuilder SetManualVersion(string version);
        CarManual Build();
    }
}
