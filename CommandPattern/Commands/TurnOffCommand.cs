using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    internal class TurnOffCommand : ICommand
    {
        private readonly ITV tv;

        internal TurnOffCommand(ITV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.Off();
        }

        public void Undo()
        {
            this.tv.On();
        }
    }
}
