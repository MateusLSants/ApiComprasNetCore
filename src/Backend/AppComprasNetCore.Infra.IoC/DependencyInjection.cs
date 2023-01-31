using AppComprasNetCore.Application.Mappings;
using AppComprasNetCore.Application.Services.Interfaces;
using AppComprasNetCore.Domain.Repositories;
using AppComprasNetCore.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppComprasNetCore.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDBContext>(options =>
                            options.UseMySql(configuration.GetConnectionString(""), new MySqlServerVersion(new Version())));
        services.AddScoped<IPersonRepository, IPersonRepository>();
        return services;
    }

    public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(DomainToDtoMappings));
        services.AddScoped<IPersonService, IPersonService>();
        return services;
    }
}
