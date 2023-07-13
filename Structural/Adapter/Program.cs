using Adapter.BankTransferExample;

var transaction = new TransactionDto() { From = "1", To = "2", Amount = 100 };


var jsonAdapter = new JsonBankApiAdapter();

jsonAdapter.ExecuteTransaction(transaction);

var xmlAdapter = new JsonBankApiAdapter();

xmlAdapter.ExecuteTransaction(transaction);

