namespace GUN_RANGE_APP_V5.Models
{
    public class InventoryViewModel
    {
        public InventoryViewModel()
        {
            InventoryItems = new List<Inventory>();
        }
        public List<Inventory> InventoryItems { get; set; }
    }
}

