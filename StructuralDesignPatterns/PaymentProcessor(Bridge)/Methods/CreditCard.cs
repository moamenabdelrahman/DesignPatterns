using PaymentProcessor.Gateways;

namespace PaymentProcessor.Methods
{
    public class CreditCard : PaymentMethod
    {
        public CreditCard(IGateway gateway): base(gateway)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Credit Card payment via {_gateway.GetType().Name}!");
        }
    }
}
