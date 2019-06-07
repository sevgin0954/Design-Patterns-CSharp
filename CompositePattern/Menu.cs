using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Menu : MenuComponent
    {
        private readonly string name;
        private readonly string description;
        private readonly List<MenuComponent> menuComponents;

        internal Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.menuComponents = new List<MenuComponent>();
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override void Add(MenuComponent component)
        {
            this.menuComponents.Add(component);
        }

        public override MenuComponent GetChild(int index)
        {
            return this.menuComponents[index];
        }

        public override void Remove(MenuComponent component)
        {
            this.menuComponents.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(this.GetName());
            Console.WriteLine(this.GetDescription());
            Console.WriteLine("--------------------------------------");

            foreach (var component in menuComponents)
            {
                component.Print();
            }
        }
    }
}
