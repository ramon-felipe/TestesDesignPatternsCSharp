using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarBuilder : ICarBuilder
    {
        private static CarBuilder instance { get; set; }
        public static CarBuilder Instance {
            get => GetCarBuilder();
        }
        private string Color { get; set; }
        private string Engine { get; set; }

        private CarBuilder()
        {
        }

        private static CarBuilder GetCarBuilder()
        {
            if (instance == null)
            {
                instance = new CarBuilder();
            }

            return instance;
        }

        public Car Build()
        {
            return new Car(this.Color, this.Engine);
        }

        public CarBuilder SetColor(string color)
        {
            this.Color = color;

            return this;
        }

        public CarBuilder SetEngine(string engine)
        {
            this.Engine = engine;

            return this;
        }
    }
}
