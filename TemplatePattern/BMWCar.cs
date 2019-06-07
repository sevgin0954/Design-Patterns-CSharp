using System;

namespace TemplatePattern
{
    internal class BMWCar : CarTemplate
    {
        internal override void SteerLeft()
        {
            Console.WriteLine("steer left");
        }

        internal override void SteerRight()
        {
            Console.WriteLine("steer right");
        }
    }
}
