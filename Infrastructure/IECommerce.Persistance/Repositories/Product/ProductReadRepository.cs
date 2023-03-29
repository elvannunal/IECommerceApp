using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class ProductReadRepository : ReadRepositories<Product>, IProductReadRepositories
{
    public ProductReadRepository(IECommerceDbContext context) : base(context)
    {
    }
}