namespace StatePattern.Interfaces
{
    internal interface ICarState
    {
        void ChangeModeToEco();
        void ChangeModeToSport();
        void PressGas();
    }
}
