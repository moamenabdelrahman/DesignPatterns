using WeatherMonitoring.Observers;

namespace WeatherMonitoring.Subjects
{
    public interface ISubject
    {
        public void Subscribe(IObserver observer);

        public void Unsubscribe(IObserver observer);

        public void Notify();

        public (int, int, int) GetState();
    }
}
