using Analytics.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Analytics.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<AnalyticsEntity> AnalyticsEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AnalyticsEntity>().ToTable("AnalyticsEntity");
    }
}