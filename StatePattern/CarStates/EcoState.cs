using StatePattern.Interfaces;
using System;

namespace StatePattern.CarStates
{
    internal class EcoState : ICarState
    {
        private readonly Car car;

        internal EcoState(Car car)
        {
            this.car = car;
        }

        public void ChangeModeToEco()
        {
            Console.WriteLine("Already on eco");
        }

        public void ChangeModeToSport()
        {
            this.car.SetState(this.car.SportState);
            Console.WriteLine("Sport mode on");
        }

        public void PressGas()
        {
            Console.WriteLine("Burn 5/100 fuel !!!!");
        }
    }
}
