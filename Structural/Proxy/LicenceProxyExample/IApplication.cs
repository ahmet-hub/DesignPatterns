namespace Proxy.LicenseProxyExample
{
    public interface IApplication
    {
        bool Login(Guid clientId);
        bool Logout(Guid clientId);
    }

    public class Application : IApplication
    {
        public bool Login(Guid clientId)
        {
            //validation
            return true;
        }

        public bool Logout(Guid clientId)
        {
            //validation
            return true;
        }
    }
}
