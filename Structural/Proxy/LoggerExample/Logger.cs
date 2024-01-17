using Serilog;

namespace Proxy.LoggerExample
{

    public interface ILogger : IDisposable
    {
        void Send(string message);
    }
    public class Logger : ILogger
    {
        public void Send(string message) => Log.Information(message);

        public void Dispose() => GC.SuppressFinalize(this);
    }


}
