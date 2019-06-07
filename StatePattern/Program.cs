namespace StatePattern
{
    class Program
    {
        static void Main()
        {
            var car = new Car();
            car.PressGas();
            car.ChangeModeToSport();
            car.PressGas();
        }
    }
}
