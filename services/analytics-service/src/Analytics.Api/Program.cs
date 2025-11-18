using Analytics.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("AnalyticsDatabase")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
