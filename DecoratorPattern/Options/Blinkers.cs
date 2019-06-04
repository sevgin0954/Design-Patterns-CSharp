using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern.Options
{
    internal class Blinkers : OptionDecorator
    {
        public Blinkers(ICar car)
            : base(car) { }

        public override decimal Price()
        {
            return this.Car.Price() + 999999;
        }

        public override void PrintModelInfo()
        {
            this.Car.PrintModelInfo();
            Console.WriteLine("    - With expirimental blinkers");
        }
    }
}
