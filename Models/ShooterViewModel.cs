namespace GUN_RANGE_APP_V5.Models
{
    public class ShooterListViewModel
    {
        public ShooterListViewModel()
        {
            Shooters = new List<Shooter>();
        }
        public List<Shooter> Shooters { get; set; }
    }
}
