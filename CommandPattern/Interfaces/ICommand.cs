namespace CommandPattern.Interfaces
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
