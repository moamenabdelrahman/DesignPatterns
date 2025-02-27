using UIGenerator.Factories;

namespace UIGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Dark Theme
            var darkFactory = new DarkFactory();
            var app = new MyApp(darkFactory);
            app.SomeOperation();

            Console.WriteLine("\n************************************************\n");

            // Test Light Theme
            var lightFactory = new LightFactory();
            app.ChangeFactory(lightFactory);
            app.SomeOperation();
        }
    }
}
