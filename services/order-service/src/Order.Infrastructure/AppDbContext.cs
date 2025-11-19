using Microsoft.EntityFrameworkCore;
using Order.Core.Model;

// using Order.Core.Model;

namespace Order.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<OrderEntity> NotificationEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<OrderEntity>().ToTable("Order");
    }
}