using Microsoft.EntityFrameworkCore;

namespace GunRangeV3.Models
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
        //can I add extra lists here for the same DB?
    }
}
