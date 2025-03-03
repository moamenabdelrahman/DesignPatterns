using SmartHome.SubSystems;

namespace SmartHome
{
    public class MyApp
    {
        public void SomeOperation()
        {
            var lighting = new LightingSystem();
            var climate = new ClimateSystem();
            var security = new SecuritySystem();

            var facade = new Facade(lighting, climate, security);

            // Test Leaving Home
            facade.LeaveHome();

            Console.WriteLine();

            // Test Returning Home
            facade.ReturnHome();
        }
    }
}
