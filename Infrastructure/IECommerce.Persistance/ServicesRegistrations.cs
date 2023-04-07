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
        services.AddDbContext<IECommerceDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
        services.AddScoped<ICustomerReadRepositories, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepositories, CustomerWriteRepository>();
        services.AddScoped<IProductReadRepositories, ProductReadRepository>();
        services.AddScoped<IProductWriteRepositories, ProductWriteRepository>();
        services.AddScoped<IOrderReadRepositories, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepositories, OrderWriteRepository>();
    }
}