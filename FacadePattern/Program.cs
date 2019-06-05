using System;

namespace FacadePattern
{
    class Program
    {
        static void Main()
        {
            var bmw = new BMW();
            var autoparkFacade = new AutoParkFacade(bmw);

            autoparkFacade.ParkIn();
            Console.WriteLine("-----------------------");
            autoparkFacade.ParkOut();
        }
    }
}
