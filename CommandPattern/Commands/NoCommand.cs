using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    internal class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}
