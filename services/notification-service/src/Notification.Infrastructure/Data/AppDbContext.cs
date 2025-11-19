using Microsoft.EntityFrameworkCore;
using Notification.Core.Model;

namespace Notification.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<NotificationEntity> NotificationEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<NotificationEntity>().ToTable("Notification");
    }
}