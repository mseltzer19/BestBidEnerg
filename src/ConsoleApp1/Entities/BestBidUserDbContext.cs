using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Entities
{
    public class BestBidUserDbContext : DbContext
    {
        public DbSet<BestBidUser> BestBidUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=tcp:bestbidenergy.database.windows.net,1433;Initial Catalog=BestBidEnergy;Trusted_Connection=True;");
        }
    }
}
