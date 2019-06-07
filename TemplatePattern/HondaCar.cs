using System;

namespace TemplatePattern
{
    internal class HondaCar : CarTemplate
    {
        internal override void SteerLeft()
        {
            Console.WriteLine("left blinkers and steer left");
        }

        internal override void SteerRight()
        {
            Console.WriteLine("right blinkers and steer right");
        }
    }
}
