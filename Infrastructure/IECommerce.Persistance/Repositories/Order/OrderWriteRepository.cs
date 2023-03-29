using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class OrderWriteRepository : WriteRepositories<Order>, IOrderWriteRepositories
{
public OrderWriteRepository(IECommerceDbContext context) : base(context)
{
}
}