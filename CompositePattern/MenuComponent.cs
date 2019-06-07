using System;

namespace CompositePattern
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual decimal GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
