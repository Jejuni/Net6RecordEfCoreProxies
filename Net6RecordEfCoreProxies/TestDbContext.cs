using Microsoft.EntityFrameworkCore;

namespace Net6RecordEfCoreProxies;

public class TestDbContext : DbContext
{
    public DbSet<MyEntity> MyEnties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseInMemoryDatabase("MyDb")
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MyEntity>().OwnsOne(x => x.MyRecord);
    }
}