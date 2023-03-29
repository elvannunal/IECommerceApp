using IEcommerce.Application.Abstractions;
using IEcommerce.Application.Repositories;
using IECommerce.Persistance.Concrate;
using IECommerce.Persistance.Contexts;
using IECommerce.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IECommerce.Persistance;

public static class ServicesRegistrations
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddDbContext<IECommerceDbContext>(options => options.UseNpgsql(Configurations.ConnectionString),
            ServiceLifetime.Singleton);
        services.AddSingleton<ICustomerReadRepositories, CustomerReadRepository>();
        services.AddSingleton<ICustomerWriteRepositories, CustomerWriteRepository>();
        services.AddSingleton<IProductReadRepositories, ProductReadRepository>();
        services.AddSingleton<IProductWriteRepositories, ProductWriteRepository>();
        services.AddSingleton<IOrderReadRepositories, OrderReadRepository>();
        services.AddSingleton<IOrderWriteRepositories, OrderWriteRepository>();
    }
}