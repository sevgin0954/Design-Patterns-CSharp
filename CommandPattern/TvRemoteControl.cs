using CommandPattern.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class TVRemoteControl
    {
        private readonly ICommand[] buttons;
        private ICommand previsionCommand = new NoCommand();

        internal TVRemoteControl(int buttonsCount)
        {
            this.buttons = new ICommand[buttonsCount];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new NoCommand();
            }
        }

        internal void SetButtonFunction(int buttonIndex, ICommand command)
        {
            this.buttons[buttonIndex] = command;
        }

        internal void PressButton(int buttonIndex)
        {
            var pressedButton = this.buttons[buttonIndex];
            pressedButton.Execute();
            this.previsionCommand = pressedButton;
        }

        internal void Undo()
        {
            this.previsionCommand.Undo();
            this.previsionCommand = new NoCommand();
        }
    }
}
