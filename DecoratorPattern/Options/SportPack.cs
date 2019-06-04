using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern.Options
{
    class SportPack : OptionDecorator
    {
        public SportPack(ICar car)
            : base(car) { }

        public override decimal Price()
        {
            return this.Car.Price() + 5000;
        }

        public override void PrintModelInfo()
        {
            this.Car.PrintModelInfo();
            Console.WriteLine("    - With super sport pack");
        }
    }
}
