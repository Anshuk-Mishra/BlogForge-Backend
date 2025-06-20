using Microsoft.EntityFrameworkCore;
using Domain.Models; 

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Students { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions){}
    }
}
