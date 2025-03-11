using WeatherMonitoring.Subjects;

namespace WeatherMonitoring.Observers
{
    public interface IObserver
    {
        public void Update(ISubject subject);
    }
}
