using Microsoft.EntityFrameworkCore;

namespace Class54a.Data
{
    public class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext> options)
            : base(options)
        { 
                
        }

        public DbSet<Food> Foods { get; set; }
    }
}
