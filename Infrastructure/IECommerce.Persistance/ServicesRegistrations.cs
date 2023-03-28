using IEcommerce.Application.Abstractions;
using IECommerce.Persistance.Concrate;
using IECommerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IECommerce.Persistance;

public static class ServicesRegistrations
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddDbContext<IECommerceDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
    }
}