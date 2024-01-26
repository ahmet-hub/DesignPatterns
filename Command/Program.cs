using Command.HomeControlExample;

//[O`Reilly. Head First] Book Example

RemoteControl remoteControl = new();

Light light = new();
Tv tv = new();
GarageDoor garageDoor = new();

remoteControl.SetCommand(1, new LightOnCommand(light), new LightOffCommand(light));
remoteControl.SetCommand(2, new TvOnCommand(tv), new TvOffCommand(tv));
remoteControl.SetCommand(3, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));

remoteControl.OnButtonWasPushed(1);
remoteControl.OnButtonWasPushed(2);
remoteControl.OnButtonWasPushed(3);

remoteControl.UndoButtonWasPushed();

remoteControl.OnButtonWasPushed(3);
remoteControl.OffButtonWasPushed(1);

remoteControl.CloseAll();

