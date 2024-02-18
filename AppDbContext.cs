using Microsoft.EntityFrameworkCore;

namespace Npgsql_3074;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}