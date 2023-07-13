namespace Adapter.BankTransferExample
{
    public class XmlBankApiAdapter : IBankTransferApi
    {
        private XmlBankTransferApi _api;

        public XmlBankApiAdapter()
        {
            _api = new();
        }

        public void ExecuteTransaction(TransactionDto dto)
        {
            _api.ExecuteTransaction(dto);
        }
    }
    
    class XmlBankTransferApi : IBankTransferApi
    {
        public void ExecuteTransaction(TransactionDto dto)
        {
            var xml = "<TransferTransaction> \n" +
                              $"<From> {dto.From} </From> \n " +
                              $"<To> {dto.To} </To> \n" +
                              $"<Amount> {dto.Amount} </Amount> \n" +
                           "</TransferTransaction>";

            //Call bank api 

            Console.WriteLine($"Request : {xml}");
            Console.WriteLine($"{GetType().Name} worked.");
        }
    }
}
