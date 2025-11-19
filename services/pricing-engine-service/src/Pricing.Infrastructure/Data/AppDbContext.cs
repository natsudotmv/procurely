using Microsoft.EntityFrameworkCore;
using Pricing.Core.Model;

namespace Pricing.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<PricingEntity> Type { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<PricingEntity>().ToTable("Pricing");
    }
}