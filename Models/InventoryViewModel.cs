namespace GUN_RANGE_APP_V5.Models
{
    public class InventoryListViewModel
    {
        public InventoryListViewModel()
        {
            Inventories = new List<Inventory>();
        }
        public List<Inventory> Inventories { get; set; }
    }
}

