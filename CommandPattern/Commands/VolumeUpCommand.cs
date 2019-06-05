using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    internal class VolumeUpCommand : ICommand
    {
        private readonly ITV tv;

        internal VolumeUpCommand(ITV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.VolumeUp();
        }

        public void Undo()
        {
            this.tv.VolumeDown();
        }
    }
}
