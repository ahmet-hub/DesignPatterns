
using FactoryMethod.PaymetExample;

var paymentManager = new PaymentManager();

paymentManager.Pay(new() { Method = PaymentMethod.Paypal, Amount = 100 });
paymentManager.Pay(new() { Method = PaymentMethod.CreditCard, Amount = 100 });
paymentManager.Pay(new() { Method = PaymentMethod.BankTransfer, Amount = 100 });