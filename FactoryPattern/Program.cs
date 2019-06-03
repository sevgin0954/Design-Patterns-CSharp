using FactoryPattern;
using System;

class Program
{
    static void Main()
    {
        var carBrand = Console.ReadLine();
        var carFactory = CarAbstractFactory.CreateCar(carBrand);
        var car = carFactory.CreateCar(CarType.sport);

        car.Crash();
    }
}