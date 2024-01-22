namespace FactoryMethod.PaymetExample
{
    public class PaymentDto
    {
        public PaymentMethod Method { get; set; }
        public decimal Amount { get; set; }
    }

    public enum PaymentMethod
    {
        CreditCard,
        Paypal,
        BankTransfer
    }
}
