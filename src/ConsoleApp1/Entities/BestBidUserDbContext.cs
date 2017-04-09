using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Entities
{
    public class BestBidUserDbContext : DbContext
    {
        public DbSet<BestBidUser> BestBidUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSQLLocalDB;Database=BestBidDb;"
                + "Trusted_Connection=True;");
        }
    }
}
