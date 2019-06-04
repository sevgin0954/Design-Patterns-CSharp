using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern
{
    internal class BMW : ICar
    {
        public decimal Price()
        {
            return 5000;
        }

        public void PrintModelInfo()
        {
            Console.WriteLine("BMW");
        }
    }
}
