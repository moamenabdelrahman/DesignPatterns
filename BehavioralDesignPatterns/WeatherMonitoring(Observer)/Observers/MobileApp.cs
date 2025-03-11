using WeatherMonitoring.Subjects;

namespace WeatherMonitoring.Observers
{
    public class MobileApp: IObserver
    {
        private int _temperature { get; set; }

        private int _humidity { get; set; }

        public MobileApp(ISubject subject)
        {
            Update(subject);
        }

        public void Display()
        {
            Console.WriteLine("Mobile App:");
            Console.WriteLine($"\tTemperature: {_temperature} degrees");
            Console.WriteLine($"\tHumidity: {_humidity} gm/cm3");
            Console.WriteLine();
        }

        public void Update(ISubject subject)
        {
            var state = subject.GetState();
            _temperature = state.Item1;
            _humidity = state.Item2;
            Display();
        }
    }
}
