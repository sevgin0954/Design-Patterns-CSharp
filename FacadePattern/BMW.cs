using System;

namespace FacadePattern
{
    internal class BMW
    {
        internal void Start()
        {
            Console.WriteLine("brrrrBRRRBRBRBRBBR BRRBBR RBRB");
        }

        internal void Stop()
        {
            Console.WriteLine("stoping");
        }

        internal void SteerLeft()
        {
            Console.WriteLine("steering right");
        }

        internal void SteerRight()
        {
            Console.WriteLine("steering left");
        }

        internal void TurnLeftBlinker()
        {
            throw new InvalidOperationException();
        }

        internal void TurnRightBlinker()
        {
            throw new InvalidOperationException();
        }
    }
}
