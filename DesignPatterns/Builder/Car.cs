using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Car
    {
        public string Color { get; private set; }

        public string Engine { get; private set; }

        public Car(string color, string engine)
        {
            this.Color = color;
            this.Engine = engine;
        }

        public override string ToString()
        {
            return $"CAR is {this.Color} and have a {Engine} motor.";
        }
    }
}
