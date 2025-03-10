using EventHandler.HomeSystems;

namespace EventHandler.Mediators
{
    public interface IHomeMediator
    {
        public void Notify(EventType type);
    }
}
