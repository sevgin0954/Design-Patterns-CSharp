using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main()
        {
            var bmwCar = new BMWCar();
            var hondaCar = new HondaCar();

            bmwCar.ParkIn();
            bmwCar.ParkOut();
            Console.WriteLine("-------------------------");
            hondaCar.ParkIn();
            hondaCar.ParkOut();
        }
    }
}
