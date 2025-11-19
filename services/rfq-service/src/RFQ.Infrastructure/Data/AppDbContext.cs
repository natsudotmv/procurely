using Microsoft.EntityFrameworkCore;
using RFQ.Core.Model;

namespace RFQ.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<RfqEntity> RfqEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<RfqEntity>().ToTable("Rfq");
    }
}