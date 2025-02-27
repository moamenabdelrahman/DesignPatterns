namespace LegacySystem.Inventory
{
    public class LegacyInventory
    {
        private int fakeStock { get; set; } = 0;

        public int GetStock(string itemCode) => fakeStock;

        public void UpdateStock(string itemCode, int quantity)
        {
            if (fakeStock + quantity < 0) throw new InvalidOperationException("No enough stock!");
            fakeStock += quantity;
        }
    }
}
