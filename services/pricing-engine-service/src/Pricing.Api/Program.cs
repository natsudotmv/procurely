using Microsoft.EntityFrameworkCore;
using Pricing.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PricingDatabase")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
