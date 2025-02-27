using LegacySystem.Inventory;

namespace LegacySystem
{
    public class MyApp
    {
        private IInventoryService _inventory { get; set; }

        public MyApp(IInventoryService inventory)
        {
            _inventory = inventory;
        }

        public void SomeOperation()
        {
            string itemCode = "ITEM123";

            // Check availability
            bool isAvailable = _inventory.CheckAvailability(itemCode);
            Console.WriteLine($"Item {itemCode} is {(isAvailable ? "available" : "out of stock")}.");

            // Adjust stock (add 10 units)
            Console.WriteLine("Adding 10 units to stock...");
            _inventory.AdjustStock(itemCode, 10);

            // Check availability again
            isAvailable = _inventory.CheckAvailability(itemCode);
            Console.WriteLine($"Item {itemCode} is now {(isAvailable ? "available" : "out of stock")}.");

            // Adjust stock (remove 5 units)
            Console.WriteLine("Removing 5 units from stock...");
            _inventory.AdjustStock(itemCode, -5);

            // Check availability one last time
            isAvailable = _inventory.CheckAvailability(itemCode);
            Console.WriteLine($"Item {itemCode} is now {(isAvailable ? "available" : "out of stock")}.");
        }
    }
}
