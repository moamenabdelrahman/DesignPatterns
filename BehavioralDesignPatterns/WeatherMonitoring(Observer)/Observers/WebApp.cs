using WeatherMonitoring.Subjects;

namespace WeatherMonitoring.Observers
{
    public class WebApp: IObserver
    {
        private int _humidity { get; set; }

        private int _pressure { get; set; }

        public WebApp(ISubject subject)
        {
            Update(subject);
        }

        public void Display()
        {
            Console.WriteLine("Web App:");
            Console.WriteLine($"\tHumidity: {_humidity} gm/cm3");
            Console.WriteLine($"\tPressure: {_pressure} Pa");
            Console.WriteLine();
        }

        public void Update(ISubject subject)
        {
            var state = subject.GetState();
            _humidity = state.Item2;
            _pressure = state.Item3;
            Display();
        }
    }
}
