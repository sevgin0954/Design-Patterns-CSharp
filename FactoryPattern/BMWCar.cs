using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern
{
    internal class BMWCar : ICar
    {
        internal BMWCar(string engine, int doortsCount)
        {
            Engine = engine;
            DoortsCount = doortsCount;
        }

        internal string Engine { get; }
        internal int DoortsCount { get; }

        public void Crash()
        {
            Console.WriteLine("Uhmhmh FORGOT THE BLINKERS AGAIN !!!!!!!!!!!!!");
        }

        public void Start()
        {
            Console.WriteLine("BRrrrrrBRrrrrBRrrrBRRBRBRBRBRBRBRBRBRBRBBRBRBRBBR");
        }

        public void Stop()
        {
            Console.WriteLine("IIIIIIIIIIIIIIIIIIIIIIIIIIIiiiiiiiiiiiiii");
        }
    }
}
