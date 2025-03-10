using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public class MailSystem: IHomeSystem
    {
        private IHomeMediator _mediator { get; set; } = null!;

        public void Send(string email, string msg)
        {
            Console.WriteLine($"Mail System: Sending \"{msg}\" to \"{email}\"");
        }

        public void SetMediator(IHomeMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
