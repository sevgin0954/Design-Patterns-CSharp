using CommandPattern.Interfaces;
using System;

namespace CommandPattern
{
    internal class TV : ITV
    {
        private const int MIN_VOLUME = 0;
        private const int MAX_VOLUME = 10;

        private int volume = 0;

        internal int Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                if (value >= MIN_VOLUME && value <= MAX_VOLUME)
                {
                    this.volume = value;
                }
            }
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void VolumeDown()
        {
            this.Volume--;
            this.PrintCurrentVolume();
        }

        public void VolumeUp()
        {
            this.Volume++;
            this.PrintCurrentVolume();
        }

        private void PrintCurrentVolume()
        {
            Console.WriteLine("Volume: " + this.Volume);
        }
    }
}
