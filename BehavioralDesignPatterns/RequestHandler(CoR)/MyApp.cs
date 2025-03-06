using RequestHandler.Handlers;
using RequestHandler.Requests;

namespace RequestHandler
{
    public class MyApp
    {
        public void SomeOperation()
        {
            // Create Handlers
            var billingHandler = new BillingHandler();
            var techHandler = new TechnicalHandler();
            var generalHandler = new GeneralHandler();

            // Order them
            billingHandler
                .SetNext(techHandler)
                .SetNext(generalHandler);

            // Test Technical Request
            var tech_request = new Request(RequestType.Technical);
            billingHandler.Handle(tech_request);

            Console.WriteLine("\n***************************************************\n");

            // Test Billing Request
            var billing_request = new Request(RequestType.Billing);
            billingHandler.Handle(billing_request);
        }
    }
}
