using Microsoft.EntityFrameworkCore;
using Npgsql_3074;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseNpgsql("Host=localhost;Username=npgsql_3074;Password=npgsql_3074;Database=npgsql_3074");
});

var app = builder.Build();

using var serviceScope = app.Services.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
dbContext.Database.Migrate();