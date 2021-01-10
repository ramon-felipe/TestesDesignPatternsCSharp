using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICarBuilder
    {
        CarBuilder SetColor(string color);
        CarBuilder SetEngine(string engine);
        Car Build();
    }
}
