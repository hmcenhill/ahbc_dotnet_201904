using Class52.Models;
using Microsoft.EntityFrameworkCore;

namespace Class52.Data
{
    public class BootCampDbContext : DbContext
    {
        public BootCampDbContext(DbContextOptions<BootCampDbContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
