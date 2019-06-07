using StatePattern.Interfaces;
using System;

namespace StatePattern.CarStates
{
    internal class SportState : ICarState
    {
        private readonly Car car;

        internal SportState(Car car)
        {
            this.car = car;
        }

        public void ChangeModeToEco()
        {
            this.car.SetState(this.car.SportState);
            Console.WriteLine("Eco mode on");
        }

        public void ChangeModeToSport()
        {
            Console.WriteLine("Already on sport");
        }

        public void PressGas()
        {
            Console.WriteLine("Burn 50/100 fuel !!!!");
        }
    }
}
