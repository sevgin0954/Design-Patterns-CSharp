namespace CompositePattern
{
    class Program
    {
        static void Main()
        {
            var mainMenu = new Menu("Sevgin restaurant menu", "Best restaurant in the world");
            var chickenFood = new MenuItem("chicken", "fried chicken", 10);
            var bread = new MenuItem("bread", "roten bread", 0.6m);
            mainMenu.Add(chickenFood);
            mainMenu.Add(bread);

            var drinksMenu = new Menu("Drinks", "Best drinks in the world");
            var tea = new MenuItem("tea", "hot tea with lemon", 55);
            drinksMenu.Add(tea);

            mainMenu.Add(drinksMenu);

            mainMenu.Print();
        }
    }
}
