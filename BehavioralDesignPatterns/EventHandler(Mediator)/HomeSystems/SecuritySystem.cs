using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public class SecuritySystem: IHomeSystem
    {
        private IHomeMediator _mediator { get; set; } = null!;

        public void Activate()
        {
            Console.WriteLine("Security System: Activating");
        }

        public void Deactivate()
        {
            Console.WriteLine("Security System: Deactivating");
        }

        public void IntrusionDetected()
        {
            Console.WriteLine("Security System: Intrusion Detected");
            _mediator.Notify(EventType.IntrusionDetected);
        }

        public void SetMediator(IHomeMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
