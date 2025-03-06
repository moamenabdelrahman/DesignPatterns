using RequestHandler.Requests;
namespace RequestHandler.Handlers
{
    public class GeneralHandler: BaseHandler
    {
        public override void Handle(Request request)
        {
            if (!CanProcess(request))
                base.Handle(request);
            else
                Console.WriteLine("The General Handler is processing the request...");
        }

        public bool CanProcess(Request request)
        {
            return request.type == RequestType.General;
        }
    }
}
