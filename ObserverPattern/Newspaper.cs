using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal class Newspaper : IObservable
    {
        private readonly IList<IObserver> subcribers = new List<IObserver>();
        private string news;

        internal string News
        {
            get
            {
                return this.news;
            }
            set
            {
                this.news = value;
                this.Notify();
            }
        }

        public void Add(IObserver observer)
        {
            subcribers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            subcribers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var subscriber in subcribers)
            {
                subscriber.Update();
            }
        }
    }
}
