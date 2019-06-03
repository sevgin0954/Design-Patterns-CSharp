using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Factories
{
    internal class HondaFactory : ICarFactory
    {
        public ICar CreateCar(CarType type)
        {
            if (type == CarType.sport)
            {
                return new HondaCar("vtec", 2);
            }
            else if (type == CarType.family)
            {
                return new HondaCar("vtec R", 4);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
