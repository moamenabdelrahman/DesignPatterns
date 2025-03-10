using EventHandler.Mediators;

namespace EventHandler.HomeSystems
{
    public interface IHomeSystem
    {
        public void SetMediator(IHomeMediator mediator);
    }
}
