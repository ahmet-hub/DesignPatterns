namespace Command.HomeControlExample
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> onCommands = new();
        private Dictionary<int, ICommand> offCommands = new();
        private Stack<ICommand> oldCommandStack = new();
        private HashSet<ICommand> closeableCommands = new();
        public RemoteControl(int supportedDeviceCount = 5)
        {
            for (int i = 0; i < supportedDeviceCount; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            oldCommandStack.Push(onCommands[slot]);
            closeableCommands.Add(offCommands[slot]);
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            oldCommandStack.Push(offCommands[slot]);
            closeableCommands.Remove(offCommands[slot]);
        }
        public void UndoButtonWasPushed()
        {
            if (oldCommandStack.Count > 0)
            {
                Console.Write("Undo last command: ");
                var oldCommand = oldCommandStack.Pop();
                oldCommand.Undo();
                closeableCommands.Remove(oldCommand);
            }
        }
        public void CloseAll()
        {
            if (closeableCommands.Count > 0)
            {
                foreach (var item in closeableCommands)
                {
                    item.Execute();
                }
            }
        }
    }
}
