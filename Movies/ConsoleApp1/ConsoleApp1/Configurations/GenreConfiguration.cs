using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Configurations;

public class GenreDbContext : DbContext
{
    public DbSet<Genre> Genres { get; set; }

    public GenreDbContext(DbContextOptions<GenreDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().ToTable("Genre");
        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId);
            entity.HasIndex(e => e.Name).IsUnique();
            entity.Property(e => e.Name).IsRequired();
            
        });

        base.OnModelCreating(modelBuilder);
    }
}