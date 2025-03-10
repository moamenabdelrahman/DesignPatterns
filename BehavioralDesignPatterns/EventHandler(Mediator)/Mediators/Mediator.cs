using EventHandler.HomeSystems;

namespace EventHandler.Mediators
{
    public class Mediator : IHomeMediator
    {
        private MailSystem _mail { get; set; }
        private LightSystem _light { get; set; }
        private Thermostat _thermo { get; set; }
        private HeatingSystem _heating { get; set; }
        private SecuritySystem _security { get; set; }

        public Mediator(MailSystem mail,
                        LightSystem lightSystem,
                        Thermostat thermostat,
                        HeatingSystem heating,
                        SecuritySystem security)
        {
            _mail = mail;
            _light = lightSystem;
            _thermo = thermostat;
            _heating = heating;
            _security = security;
        }

        public void Notify(EventType type)
        {
            switch (type)
            {
                case EventType.IntrusionDetected:
                    _mail.Send("owner@gmail.com", "Alert: Intrusion Detected!!!");
                    _light.TurnOn();
                    break;
                case EventType.TemperatureDrop:
                    _heating.TurnOn();
                    break;
                case EventType.LightsTurnedOff:
                    _security.Activate();
                    break;
            }
        }
    }
}
