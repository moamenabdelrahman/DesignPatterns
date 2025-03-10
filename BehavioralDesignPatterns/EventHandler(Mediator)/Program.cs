using EventHandler.HomeSystems;
using EventHandler.Mediators;

namespace EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mail = new MailSystem();
            var light = new LightSystem();
            var thermo = new Thermostat();
            var heating = new HeatingSystem();
            var security = new SecuritySystem();

            var mediator = new Mediator(mail, light, thermo, heating, security);

            // Set mediators for each device
            mail.SetMediator(mediator);
            light.SetMediator(mediator);
            thermo.SetMediator(mediator);
            heating.SetMediator(mediator);
            security.SetMediator(mediator);

            // Simulate events
            security.IntrusionDetected(); // Turns on lights and sends an email

            Console.WriteLine();

            thermo.TempDropDetected();   // Turns on heating

            Console.WriteLine();

            light.TurnOff();             // Activates security
        }
    }
}
