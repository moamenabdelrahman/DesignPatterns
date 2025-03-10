using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public class LightSystem: IHomeSystem
    {
        private IHomeMediator _mediator { get; set; } = null!;

        public void TurnOn()
        {
            Console.WriteLine("Light System: Turning On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light System: Turning Off");
            _mediator.Notify(EventType.LightsTurnedOff);
        }

        public void SetMediator(IHomeMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
