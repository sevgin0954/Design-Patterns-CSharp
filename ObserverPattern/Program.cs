using ObserverPattern;

class Program
{
    static void Main()
    {
        var newspaper = new Newspaper();
        var subscriber1 = new Subscriber(newspaper);
        var subscriber2 = new Subscriber(newspaper);

        newspaper.News = "New news";
    }
}