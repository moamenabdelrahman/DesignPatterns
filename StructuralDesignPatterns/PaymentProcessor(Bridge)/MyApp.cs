using PaymentProcessor.Gateways;
using PaymentProcessor.Methods;

namespace PaymentProcessor
{
    public class MyApp
    {
        public void SomeOperation()
        {
            // Test Credit Card via Stripe
            IGateway gateway = new Stripe();
            PaymentMethod method = new CreditCard(gateway);
            method.ProcessPayment();

            Console.WriteLine();

            // Test Credit Card via Stripe
            gateway = new BlockChain();
            method = new Cryptocurrency(gateway);
            method.ProcessPayment();
        }
    }
}
