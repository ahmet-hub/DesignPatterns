using Proxy.LoggerExample;
using Serilog;
using Serilog.Events;
using ILogger = Proxy.LoggerExample.ILogger;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
    .CreateLogger();

ILogger logger = LoggerFactory.Create();
logger.Send("Process 1 started.");
logger.Send("Process 1 in progress.");
logger.Send("Process 1 completed.");

logger.Dispose();

logger = LoggerFactory.Create();
logger.Send("Process 2 started.");
logger.Send("Process 2 in progress.");
logger.Send("Process 2 completed.");

logger.Dispose();