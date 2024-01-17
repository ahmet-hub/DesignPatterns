using System.Text.Json;

namespace Proxy.LoggerExample
{
    public class LoggerProxy : ILogger
    {
        private readonly ILogger logger;
        private readonly List<LogMessage> logMessages;
        private bool disposed = false;

        public LoggerProxy(ILogger logger)
        {
            this.logger = logger;
            logMessages = new List<LogMessage>();
        }

        public void Send(string message)
        {
            logMessages.Add(new LogMessage
            {
                Step = logMessages.Count + 1,
                Message = $"[{DateTime.Now}] - {message}"
            });
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    logger.Send(JsonSerializer.Serialize(logMessages));
                }
                disposed = true;
            }
        }
    }


    public class LogMessage
    {
        public int Step { get; set; }
        public string Message { get; set; }
    }
}
