using Auth.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Auth.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set;  }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>().ToTable("User");
    }
}