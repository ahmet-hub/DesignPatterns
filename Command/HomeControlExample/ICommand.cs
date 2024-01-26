namespace Command.HomeControlExample
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class NoCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Not Supported");
        public void Undo() => Console.WriteLine("Not Supported");
    }
}
