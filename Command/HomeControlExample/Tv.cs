namespace Command.HomeControlExample
{
    public class Tv
    {
        public void On() => Console.WriteLine("Tv is on.");

        public void Off() => Console.WriteLine("Tv is off.");
    }

    public class TvOnCommand : ICommand
    {
        private readonly Tv tv;

        public TvOnCommand(Tv tv)
        {
            this.tv = tv;
        }

        public void Execute() => tv.On();
        public void Undo() => tv.Off();
    }

    public class TvOffCommand : ICommand
    {
        private readonly Tv tv;

        public TvOffCommand(Tv tv)
        {
            this.tv = tv;
        }

        public void Execute() => tv.Off();

        public void Undo() => tv.On();
    }
}
