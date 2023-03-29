using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class ProductWriteRepository : WriteRepositories<Product>, IProductWriteRepositories
{
    public ProductWriteRepository(IECommerceDbContext context) : base(context)
    {
    }
}