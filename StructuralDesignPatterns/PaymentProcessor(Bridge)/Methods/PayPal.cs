using PaymentProcessor.Gateways;

namespace PaymentProcessor.Methods
{
    public class PayPal : PaymentMethod
    {
        public PayPal(IGateway gateway): base(gateway)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment via {_gateway.GetType().Name}!");
        }
    }
}
