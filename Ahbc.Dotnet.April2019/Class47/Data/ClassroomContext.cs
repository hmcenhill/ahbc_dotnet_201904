using Microsoft.EntityFrameworkCore;

namespace Class47.Data
{
    public class ClassroomContext : DbContext
    {
        public ClassroomContext(DbContextOptions<ClassroomContext> options) 
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}