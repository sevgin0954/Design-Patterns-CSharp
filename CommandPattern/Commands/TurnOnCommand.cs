using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    internal class TurnOnCommand : ICommand
    {
        private readonly ITV tv;

        internal TurnOnCommand(ITV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.On();
        }

        public void Undo()
        {
            this.tv.Off();
        }
    }
}
