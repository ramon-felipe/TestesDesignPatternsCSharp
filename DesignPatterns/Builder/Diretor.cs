using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Diretor
    {

        public Car BuildCar(string carType)
        {
            CarBuilder carBuilder = CarBuilder.Instance;

            if (carType.Equals("blue"))
            {
                return carBuilder
                    .SetColor("blue")
                    .SetEngine("2.0")
                    .Build();
            }
            else
            {
                return carBuilder
                    .SetColor("white")
                    .SetEngine("1.0")
                    .Build();
            }
        }

        public CarManual BuildCarManual()
        {
            CarManualBuilder carManualBuilder = CarManualBuilder.GetInstance();

            return carManualBuilder.SetNumPages(10).SetManualVersion("2.3.1").Build();
        }
    }
}
