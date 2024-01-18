using Proxy.LicenseProxyExample;

#region Logger Example
//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Debug()
//    .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
//    .CreateLogger();

//ILogger logger = LoggerFactory.Create();
//logger.Send("Process 1 started.");
//logger.Send("Process 1 in progress.");
//logger.Send("Process 1 completed.");

//logger.Dispose();

//logger = LoggerFactory.Create();
//logger.Send("Process 2 started.");
//logger.Send("Process 2 in progress.");
//logger.Send("Process 2 completed.");

//logger.Dispose(); 
#endregion

#region LicenseProxyExample

IApplication application = new ApplicationProxy();

var client1 = Guid.NewGuid();
var client2 = Guid.NewGuid();
var client3 = Guid.NewGuid();
var client4 = Guid.NewGuid();

application.Login(client1);
application.Login(client2);
application.Login(client3);
application.Login(client4);

application.Logout(Guid.NewGuid());
application.Logout(client1); 
#endregion

