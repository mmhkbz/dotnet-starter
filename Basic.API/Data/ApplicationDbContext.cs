using Microsoft.EntityFrameworkCore;

namespace Basic.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Add your DbSet properties here
    // Example:
    // public DbSet<YourEntity> YourEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Add your entity configurations here
        // Example:
        // modelBuilder.Entity<YourEntity>().HasKey(e => e.Id);
    }
}
