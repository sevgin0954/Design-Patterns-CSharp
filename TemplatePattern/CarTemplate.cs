using System;

namespace TemplatePattern
{
    abstract internal class CarTemplate
    {
        internal void ParkIn()
        {
            this.SteerLeft();
            this.SteerRight();
            this.Stop();
        }

        internal void ParkOut()
        {
            this.Start();
            this.SteerLeft();
            this.SteerRight();
        }

        internal void Start()
        {
            Console.WriteLine("Car started");
        }

        internal void Stop()
        {
            Console.WriteLine("Car stoped");
        }

        internal abstract void SteerLeft();

        internal abstract void SteerRight();
    }
}
