using PaymentProcessor.Gateways;

namespace PaymentProcessor.Methods
{
    public class Cryptocurrency : PaymentMethod
    {
        public Cryptocurrency(IGateway gateway): base(gateway)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Cryptocurrency payment via {_gateway.GetType().Name}!");
        }
    }
}
