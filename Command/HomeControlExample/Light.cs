namespace Command.HomeControlExample
{
    public class Light
    {
        public void On() => Console.WriteLine("Light is on.");

        public void Off() => Console.WriteLine("Light is off.");
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light Light;

        public LightOnCommand(Light light) => Light = light;

        public void Execute() => Light.On();

        public void Undo() => Light.Off();
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light Light;

        public LightOffCommand(Light light) => Light = light;

        public void Execute() => Light.Off();
        public void Undo() => Light.On();
    }
}
