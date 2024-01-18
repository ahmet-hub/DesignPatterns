namespace Proxy.LicenseProxyExample
{
    public class ApplicationProxy : IApplication
    {
        private const int MaxUserCount = 2;
        private int CurrentUserCount;
        private List<WaitingClient> waitingClients;
        private List<Guid?> loginClients;
        private readonly IApplication application;

        public ApplicationProxy()
        {
            waitingClients = new();
            loginClients = new();
            application = new Application();
        }

        public bool Login(Guid clientId)
        {
            if (CurrentUserCount < MaxUserCount)
            {
                var isSuccess = application.Login(clientId);
                if (isSuccess)
                {
                    loginClients.Add(clientId);
                    Console.WriteLine($"[Information Log] Client : {clientId} logged in.");
                    CurrentUserCount++;
                }
                return isSuccess;
            }
            int currentMaxOrder = 1;
            if (waitingClients.Any())
                currentMaxOrder = waitingClients.Max(x => x.Order) + 1;

            waitingClients.Add(new WaitingClient
            {
                ClientId = clientId,
                Order = currentMaxOrder
            });

            Console.WriteLine($"[Information Log] Maximum number of clients has been reached, your turn is {currentMaxOrder}.");

            return false;
        }
        public bool Logout(Guid clientId)
        {
            var client = loginClients.FirstOrDefault(x => x == clientId);
            if (client != null)
            {
                var isSuccess = application.Logout(clientId);
                if (isSuccess)
                {
                    CurrentUserCount--;
                    var nextClient = waitingClients.OrderBy(x => x.Order)
                        .FirstOrDefault();
                    Console.WriteLine($"[Information Log] Client {clientId} has logged out of the system.");
                    if (nextClient != null)
                    {
                        Login(nextClient.ClientId);
                    }
                }
                return isSuccess;
            }

            Console.WriteLine($"[Information Log] Client {clientId} not found.");
            return false;
        }
    }
}
