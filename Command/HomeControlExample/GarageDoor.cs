namespace Command.HomeControlExample
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage door opens");

        public void Down() => Console.WriteLine("Garage door closing");
    }

    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor GarageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor) => GarageDoor = garageDoor;

        public void Execute() => GarageDoor.Up();

        public void Undo() => GarageDoor.Down();
    }
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor GarageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor) => GarageDoor = garageDoor;

        public void Execute() => GarageDoor.Down();

        public void Undo() => GarageDoor.Up();
    }
}
