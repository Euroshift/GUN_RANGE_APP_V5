namespace GunRangeV3.Models
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
