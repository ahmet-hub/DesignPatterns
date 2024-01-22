namespace FactoryMethod.PaymetExample
{
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
}
