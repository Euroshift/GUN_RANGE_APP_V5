using Microsoft.EntityFrameworkCore;

namespace GUN_RANGE_APP_V5.Models
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));

        }

        public DbSet<Shooter> Shooters {  get; set; } 
        public DbSet<Inventory> Inventories {  get; set; } 
        //can I add extra lists here for the same DB?
    }
}
