using PaymentProcessor.Gateways;

namespace PaymentProcessor.Methods
{
    public abstract class PaymentMethod
    {
        protected IGateway _gateway { get; set; }

        protected PaymentMethod(IGateway gateway)
        {
            _gateway = gateway;
        }

        public abstract void ProcessPayment();
    }
}
