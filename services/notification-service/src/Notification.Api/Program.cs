using Microsoft.EntityFrameworkCore;
using Notification.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("NotificationDatabase")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
