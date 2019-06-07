using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern.Options
{
    class SportPack : OptionDecorator
    {
        internal SportPack(ICar car)
            : base(car) { }

        internal override decimal Price()
        {
            return this.Car.Price() + 5000;
        }

        internal override void PrintModelInfo()
        {
            this.Car.PrintModelInfo();
            Console.WriteLine("    - With super sport pack");
        }
    }
}
