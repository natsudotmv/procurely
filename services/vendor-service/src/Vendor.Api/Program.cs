using Microsoft.EntityFrameworkCore;
using Vendor.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("VendorDatabase")));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
