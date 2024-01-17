namespace Proxy.LoggerExample
{
    public static class LoggerFactory
    {
        public static ILogger Create() => new LoggerProxy(new Logger());
    }
}
