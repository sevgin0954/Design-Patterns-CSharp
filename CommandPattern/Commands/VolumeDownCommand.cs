using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    internal class VolumeDownCommand : ICommand
    {
        private readonly ITV tv;

        internal VolumeDownCommand(ITV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.VolumeDown();
        }

        public void Undo()
        {
            this.tv.VolumeUp();
        }
    }
}
