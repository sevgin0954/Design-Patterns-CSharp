using StatePattern.CarStates;
using StatePattern.Interfaces;

namespace StatePattern
{
    internal class Car
    {
        private ICarState currentState;

        internal EcoState EcoState { get; }
        internal SportState SportState { get; }

        internal Car()
        {
            this.EcoState = new EcoState(this);
            this.currentState = this.EcoState;
            this.SportState = new SportState(this);
        }

        internal void ChangeModeToEco()
        {
            this.currentState.ChangeModeToEco();
        }

        internal void ChangeModeToSport()
        {
            this.currentState.ChangeModeToSport();
        }

        internal void PressGas()
        {
            this.currentState.PressGas();
        }

        internal void SetState(ICarState state)
        {
            this.currentState = state;
        }
    }
}
