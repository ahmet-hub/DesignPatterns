namespace FactoryMethod.PaymetExample
{
    public class PaymentDto
    {
        public PaymentMethod Method { get; set; }
        public decimal Amount { get; set; }
    }

    public class PaymentManager
    {
        public void Pay(PaymentDto paymentDto)
        {
            var paymentProcessor = PaymentProcessorFactory.Create(paymentDto.Method);

            paymentProcessor.Payment(paymentDto.Amount);
        }
    }

    public class PaymentProcessorFactory
    {
        public static IPaymentProcessor Create(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.Paypal => new PaypalPayment(),
                PaymentMethod.CreditCard => new CreditCardPayment(),
                PaymentMethod.BankTransfer => new BankTransferPayment(),
                _ => throw new NotImplementedException(),
            };
        }
    }

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
