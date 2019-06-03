using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern
{
    internal class HondaCar : ICar
    {
        public HondaCar(string engine, int doortsCount)
        {
            Engine = engine;
            DoortsCount = doortsCount;
        }

        public string Engine { get; }
        public int DoortsCount { get; }

        public void Crash()
        {
            Console.WriteLine("No more street racing");
        }

        public void Start()
        {
            Console.WriteLine("brbrbrbrbrbr VTEC ON BRBRBRBRBBRBRBRBRBRBRBRBRBRBRBRBRRB");
        }

        public void Stop()
        {
            Console.WriteLine("iii");
        }
    }
}
