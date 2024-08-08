using Microsoft.EntityFrameworkCore;

public class StockTrackerDbContext : DbContext
{
    public StockTrackerDbContext(DbContextOptions<StockTrackerDbContext> options)
        : base(options)
    {
    }

    public DbSet<IndexMarket> Indexes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity relationships, constraints, etc. here
        base.OnModelCreating(modelBuilder);
    }
}
