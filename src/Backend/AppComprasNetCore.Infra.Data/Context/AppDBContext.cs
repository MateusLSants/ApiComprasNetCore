using Microsoft.EntityFrameworkCore;

namespace AppComprasNetCore.Infra.Data.Context;

public class AppDBContext : DbContext
{

	public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
	{ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
    }
}
