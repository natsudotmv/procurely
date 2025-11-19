using Microsoft.EntityFrameworkCore;
using Order.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("OrderDatabase")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
