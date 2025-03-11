using WeatherMonitoring.Observers;

namespace WeatherMonitoring.Subjects
{
    public class WeatherStation: ISubject
    {
        private int _temperature { get; set; }

        private int _humidity { get; set; }
        
        private int _pressure { get; set; }

        private List<IObserver> _observers { get; set; } = new List<IObserver>();

        public WeatherStation(int temp, int hum, int pressure)
        {
            _temperature = temp;
            _humidity = hum;
            _pressure = pressure;
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(this);
        }

        public (int, int, int) GetState()
        {
            return (_temperature, _humidity, _pressure);
        }

        public void SetState(int temp, int humidity, int pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }
    }
}
