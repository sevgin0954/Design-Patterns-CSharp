using System;

namespace FacadePattern
{
    internal class BMW
    {
        public void Start()
        {
            Console.WriteLine("brrrrBRRRBRBRBRBBR BRRBBR RBRB");
        }

        public void Stop()
        {
            Console.WriteLine("stoping");
        }

        public void SteerLeft()
        {
            Console.WriteLine("steering right");
        }

        public void SteerRight()
        {
            Console.WriteLine("steering left");
        }

        public void TurnLeftBlinker()
        {
            throw new InvalidOperationException();
        }

        public void TurnRightBlinker()
        {
            throw new InvalidOperationException();
        }
    }
}
