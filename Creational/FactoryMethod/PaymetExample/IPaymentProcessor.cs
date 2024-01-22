namespace FactoryMethod.PaymetExample
{
    public interface IPaymentProcessor
    {
        public void Payment(decimal amount);
    }

    public class CreditCardPayment : IPaymentProcessor
    {
        public void Payment(decimal amount)
        {
            //CreditCardPayment Implementation
            Console.WriteLine($"Pay with CreditCard : {amount}");
        }
    }

    public class PaypalPayment : IPaymentProcessor
    {
        public void Payment(decimal amount)
        {
            //PaypalPayment Implementation
            Console.WriteLine($"Pay with Paypal : {amount}");
        }
    }

    public class BankTransferPayment : IPaymentProcessor
    {
        public void Payment(decimal amount)
        {
            //BankTransferPayment Implementation
            Console.WriteLine($"Pay with BankTransfer : {amount}");
        }
    }
}
