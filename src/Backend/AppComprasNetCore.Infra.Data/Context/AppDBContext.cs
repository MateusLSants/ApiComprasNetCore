using AppComprasNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppComprasNetCore.Infra.Data.Context;

public class AppDBContext : DbContext
{

	public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
	{ }

    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Purchase> purchases { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
    }
}
