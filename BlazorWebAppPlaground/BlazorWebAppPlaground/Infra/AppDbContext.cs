using BlazorWebAppPlaground.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppPlaground.Infra;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}


