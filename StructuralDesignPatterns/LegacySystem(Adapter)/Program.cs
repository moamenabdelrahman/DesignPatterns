using LegacySystem.Inventory;

namespace LegacySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Adapter();
            var app = new MyApp(inventory);

            app.SomeOperation();
        }
    }
}
