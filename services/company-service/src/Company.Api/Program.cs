using Microsoft.EntityFrameworkCore;
using Company.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("CompanyDatabase")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
