using RequestHandler.Requests;

namespace RequestHandler.Handlers
{
    public interface IHandler
    {
        public void Handle(Request request);

        public IHandler SetNext(IHandler next);
    }
}
