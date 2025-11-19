using Microsoft.EntityFrameworkCore;
using RFQ.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("RfqDatabase")));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
