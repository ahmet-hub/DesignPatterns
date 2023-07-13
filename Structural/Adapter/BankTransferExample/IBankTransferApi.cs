namespace Adapter.BankTransferExample
{
    public interface IBankTransferApi
    {
        void ExecuteTransaction(TransactionDto dto);
    }
}
