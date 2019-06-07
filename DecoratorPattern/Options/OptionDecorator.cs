using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Options
{
    internal abstract class OptionDecorator : ICar
    {
        internal OptionDecorator(ICar car)
        {
            this.Car = car;
        }

        internal ICar Car { get; }

        public abstract decimal Price();
        public abstract void PrintModelInfo();
    }
}
