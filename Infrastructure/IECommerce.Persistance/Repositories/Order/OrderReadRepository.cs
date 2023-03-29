using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class OrderReadRepository : ReadRepositories<Order>, IOrderReadRepositories
{
    public OrderReadRepository(IECommerceDbContext context) : base(context)
    {
    }
}