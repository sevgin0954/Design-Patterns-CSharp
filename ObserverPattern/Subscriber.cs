using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    internal class Subscriber : IObserver, IDisplay
    {
        private readonly Newspaper newspaper;

        public Subscriber(Newspaper newspaper)
        {
            this.newspaper = newspaper;
            this.newspaper.Add(this);
        }

        public void Update()
        {
            var newsText = this.newspaper.News;
            this.Display(newsText);
        }

        public void Display(string data)
        {
            Console.WriteLine(data);
        }
    }
}
