using Microsoft.EntityFrameworkCore;

public class LearndataContext : DbContext
{
    public LearndataContext(DbContextOptions<LearndataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    // Other DbSet properties for your entities...
}
