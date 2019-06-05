namespace FacadePattern
{
    internal class AutoParkFacade
    {
        private readonly BMW bmwCar;

        internal AutoParkFacade(BMW bmwCar)
        {
            this.bmwCar = bmwCar;
        }

        internal void ParkIn()
        {
            this.bmwCar.SteerLeft();
            this.bmwCar.SteerRight();
            this.bmwCar.Stop();
        }

        internal void ParkOut()
        {
            this.bmwCar.Start();
            this.bmwCar.SteerLeft();
            this.bmwCar.SteerRight();
        }
    }
}
