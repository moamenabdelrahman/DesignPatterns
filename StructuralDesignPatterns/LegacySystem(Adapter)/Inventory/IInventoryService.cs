namespace LegacySystem.Inventory
{
    public interface IInventoryService
    {
        public bool CheckAvailability(string itemCode);
        public void AdjustStock(string itemCode, int quantity);
    }
}
