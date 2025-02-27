namespace LegacySystem.Inventory
{
    public class Adapter : IInventoryService
    {
        private LegacyInventory legacy { get; set; } = new LegacyInventory();

        public void AdjustStock(string itemCode, int quantity)
        {
            legacy.UpdateStock(itemCode, quantity);
        }

        public bool CheckAvailability(string itemCode)
        {
            return legacy.GetStock(itemCode) > 0;
        }
    }
}
