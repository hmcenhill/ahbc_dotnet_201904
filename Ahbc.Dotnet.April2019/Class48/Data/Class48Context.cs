using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Class48.Data
{
    public partial class Class48Context : DbContext
    {
        public Class48Context()
        {
        }

        public Class48Context(DbContextOptions<Class48Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Directors>(entity =>
            {
                entity.HasKey(e => e.DirectorId)
                    .HasName("PK__Director__26C69E26D7766E8F");

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasKey(e => e.MovieId)
                    .HasName("PK__Movies__4BD2943A71768EAA");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.DirectorId)
                    .HasConstraintName("FK__Movies__Director__398D8EEE");
            });
        }
    }
}
