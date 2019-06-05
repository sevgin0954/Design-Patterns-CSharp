using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main()
        {
            var tv = new TV();

            var turnOffCommand = new TurnOffCommand(tv);
            var turnOnCommand = new TurnOnCommand(tv);
            var volumeUpCommand = new VolumeUpCommand(tv);
            var volumeDownCommand = new VolumeDownCommand(tv);

            var buttonsCount = 5;
            var tvRemoteControl = new TVRemoteControl(buttonsCount);
            tvRemoteControl.SetButtonFunction(0, turnOffCommand);
            tvRemoteControl.SetButtonFunction(1, turnOnCommand);
            tvRemoteControl.SetButtonFunction(2, volumeUpCommand);
            tvRemoteControl.SetButtonFunction(3, volumeDownCommand);

            for (int i = 0; i < buttonsCount; i++)
            {
                tvRemoteControl.PressButton(i);
            }
        }
    }
}
