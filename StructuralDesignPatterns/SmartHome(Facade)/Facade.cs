using SmartHome.SubSystems;

namespace SmartHome
{
    public class Facade
    {
        private LightingSystem _lighting { get; set; }
        private ClimateSystem _climate { get; set; }
        private SecuritySystem _security { get; set; }

        public Facade(LightingSystem lighting, ClimateSystem climate, SecuritySystem security)
        {
            _lighting = lighting;
            _climate = climate;
            _security = security;
        }

        public void LeaveHome()
        {
            Console.WriteLine("Leaving Home...");
            _lighting.TurnOff();
            _climate.AdjustTemperature();
            _security.Activate();
        }

        public void ReturnHome()
        {
            Console.WriteLine("Returning Home...");
            _lighting.TurnOn();
            _climate.AdjustTemperature();
            _security.Deactivate();
        }
    }
}
