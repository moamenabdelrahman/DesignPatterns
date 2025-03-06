namespace RequestHandler.Requests
{
    public class Request
    {
        public RequestType type { get; private set; }

        public Request(RequestType requestType)
        {
            type = requestType;
        }
    }

    public enum RequestType
    {
        Billing,
        Technical,
        General
    }
}
