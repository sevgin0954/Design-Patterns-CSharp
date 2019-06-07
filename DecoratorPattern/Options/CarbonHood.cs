using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern.Options
{
    internal class CarbonHood : OptionDecorator
    {
        internal CarbonHood(ICar car)
            : base(car) { }

        public override decimal Price()
        {
            return this.Car.Price() + 1500;
        }

        public override void PrintModelInfo()
        {
            this.Car.PrintModelInfo();
            Console.WriteLine("    - With Carbon hood");
        }
    }
}
