using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Options
{
    internal abstract class OptionDecorator : ICar
    {
        public OptionDecorator(ICar car)
        {
            this.Car = car;
        }

        public ICar Car { get; }

        public abstract decimal Price();
        public abstract void PrintModelInfo();
    }
}
