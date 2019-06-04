using DecoratorPattern.Interfaces;
using DecoratorPattern.Options;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            ICar baseBmw = new BMW();
            baseBmw = new Blinkers(baseBmw);
            baseBmw = new CarbonHood(baseBmw);

            Console.WriteLine("Total price : " + baseBmw.Price());
            baseBmw.PrintModelInfo();
        }
    }
}
