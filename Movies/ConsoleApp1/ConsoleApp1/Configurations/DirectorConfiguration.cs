using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Configurations;

public class DirectorDbContext : DbContext
{
    public DbSet<Director> Directors { get; set; }

    public DirectorDbContext(DbContextOptions<DirectorDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Director>().ToTable("Director");
        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.DirectorId);
            entity.HasIndex(e => e.Name).IsUnique();
            entity.Property(e => e.Name).IsRequired();
            
        });

        base.OnModelCreating(modelBuilder);
    }
}