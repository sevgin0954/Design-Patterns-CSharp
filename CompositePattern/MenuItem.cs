using System;

namespace CompositePattern
{
    internal class MenuItem : MenuComponent
    {
        private readonly string name;
        private readonly string description;
        private readonly decimal price;

        internal MenuItem(string name, string description, decimal price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override decimal GetPrice()
        {
            return this.price;
        }

        public override void Print()
        {
            Console.WriteLine(this.GetName());
            Console.WriteLine("    $" + this.GetPrice());
        }
    }
}
