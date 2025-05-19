using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Configurations;

public class ActorDbContext : DbContext
{
    public DbSet<Actor> Actors { get; set; }

    public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().ToTable("Actor");
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.ActorId);
            entity.HasIndex(e => e.Name).IsUnique();
            entity.Property(e => e.Name).IsRequired();
            
        });

        base.OnModelCreating(modelBuilder);
    }
}