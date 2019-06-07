namespace IteratorPattern.Interfaces
{
    internal interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
