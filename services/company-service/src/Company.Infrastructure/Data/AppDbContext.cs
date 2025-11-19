using Microsoft.EntityFrameworkCore;
using Company.Core.Model;

namespace Company.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<CompanyEntity> CompanyEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<CompanyEntity>().ToTable("Company");
    }
}