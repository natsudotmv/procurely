using Microsoft.EntityFrameworkCore;
using Vendor.Core.Model;

namespace Vendor.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<VendorEntity> VendorEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<VendorEntity>().ToTable("Vendor");
    }
}