using RequestHandler.Requests;

namespace RequestHandler.Handlers
{
    public class BillingHandler: BaseHandler
    {
        public override void Handle(Request request)
        {
            if (!CanProcess(request))
                base.Handle(request);
            else
                Console.WriteLine("The Billing Handler is processing the request...");
        }

        public bool CanProcess(Request request)
        {
            return request.type == RequestType.Billing;
        }
    }
}
