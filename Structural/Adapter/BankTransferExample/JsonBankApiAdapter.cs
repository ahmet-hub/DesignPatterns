using System.Text.Json;

namespace Adapter.BankTransferExample
{
    public class JsonBankApiAdapter : IBankTransferApi
    {
        private JsonBankTransferApi _api;

        public JsonBankApiAdapter()
        {
            _api = new();
        }

        public void ExecuteTransaction(TransactionDto dto)
        {
            _api.ExecuteTransaction(dto);
        }
    }

    internal class JsonBankTransferApi : IBankTransferApi
    {
        public void ExecuteTransaction(TransactionDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            // call bank api

            Console.WriteLine($"Request : {json}");
            Console.WriteLine($"{GetType().Name} worked.");

        }
    }
}
