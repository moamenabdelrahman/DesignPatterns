using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public class HeatingSystem: IHomeSystem
    {
        private IHomeMediator _mediator { get; set; } = null!;

        public void TurnOn()
        {
            Console.WriteLine("Heating System: Turning On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Heating System: Turning Off");
        }

        public void SetMediator(IHomeMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
