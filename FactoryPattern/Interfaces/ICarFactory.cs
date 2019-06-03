namespace FactoryPattern.Interfaces
{
    internal interface ICarFactory
    {
        ICar CreateCar(CarType type);
    }
}
