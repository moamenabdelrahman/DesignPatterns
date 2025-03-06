using RequestHandler.Requests;

namespace RequestHandler.Handlers
{
    public class BaseHandler : IHandler
    {
        private IHandler? _next { get; set; }

        public virtual void Handle(Request request)
        {
            if (_next != null)
                _next.Handle(request);
        }

        public IHandler SetNext(IHandler next)
        {
            _next = next;
            return next;
        }
    }
}
