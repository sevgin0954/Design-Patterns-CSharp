using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Factories
{
    internal class BMWFactory : ICarFactory
    {
        public ICar CreateCar(CarType type)
        {
            if (type == CarType.family)
            {
                return new BMWCar("2L bmw", 4);
            }
            else if (type == CarType.sport)
            {
                return new BMWCar("16L BMW SPORT", 2);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
