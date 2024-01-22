namespace FactoryMethod.PaymetExample
{
    public class PaymentManager
    {
        public void Pay(PaymentDto paymentDto)
        {
            var paymentProcessor = PaymentProcessorFactory.Create(paymentDto.Method);
            paymentProcessor.Payment(paymentDto.Amount);
        }
    }
}
