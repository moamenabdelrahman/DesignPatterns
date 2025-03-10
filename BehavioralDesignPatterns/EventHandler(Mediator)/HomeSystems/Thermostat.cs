using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public class Thermostat: IHomeSystem
    {
        private IHomeMediator _mediator { get; set; } = null!;

        public void SetMediator(IHomeMediator mediator)
        {
            _mediator = mediator;
        }

        public void TempDropDetected()
        {
            Console.WriteLine("Thermostat: Temperature Drop Detected");
            _mediator.Notify(EventType.TemperatureDrop);
        }
    }
}
