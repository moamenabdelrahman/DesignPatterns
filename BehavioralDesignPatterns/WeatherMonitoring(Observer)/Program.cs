using WeatherMonitoring.Observers;
using WeatherMonitoring.Subjects;

namespace WeatherMonitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherStation = new WeatherStation(30, 65, 1020);
            var mobileApp = new MobileApp(weatherStation);
            var webApp = new WebApp(weatherStation);
            var desktopApp = new DesktopApp(weatherStation);

            Console.WriteLine("**********************************************\n");

            // Subscribe observers
            weatherStation.Subscribe(mobileApp);
            weatherStation.Subscribe(webApp);
            weatherStation.Subscribe(desktopApp);

            // Update weather data
            weatherStation.SetState(25, 60, 1013);

            Console.WriteLine("**********************************************\n");

            // Unsubscribe an observer
            weatherStation.Unsubscribe(webApp);

            // Update weather data again
            weatherStation.SetState(28, 55, 1012);
        }
    }
}
