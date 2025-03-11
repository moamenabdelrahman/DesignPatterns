using WeatherMonitoring.Subjects;

namespace WeatherMonitoring.Observers
{
    public class DesktopApp: IObserver
    {
        private int _temperature { get; set; }

        private int _pressure { get; set; }

        public DesktopApp(ISubject subject)
        {
            Update(subject);
        }

        public void Display()
        {
            Console.WriteLine("Desktop App:");
            Console.WriteLine($"\tTemperature: {_temperature} degrees");
            Console.WriteLine($"\tPressure: {_pressure} Pa");
            Console.WriteLine();
        }

        public void Update(ISubject subject)
        {
            var state = subject.GetState();
            _temperature = state.Item1;
            _pressure = state.Item3;
            Display();
        }
    }
}
