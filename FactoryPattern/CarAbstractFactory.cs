using FactoryPattern.Factories;
using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern
{
    internal static class CarAbstractFactory
    {
        internal static ICarFactory CreateCar(string carBrand)
        {
            if (carBrand == "bmw")
            {
                return new BMWFactory();
            }
            else if (carBrand == "honda")
            {
                return new HondaFactory();
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
