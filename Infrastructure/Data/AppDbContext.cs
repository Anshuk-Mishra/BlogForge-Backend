using Microsoft.EntityFrameworkCore;
using Domain.Models; 

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Dev");
        }
    }
}
