using Microsoft.EntityFrameworkCore;

namespace Quote.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
}