using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class CustomerWriteRepository : WriteRepositories<Customer>, ICustomerWriteRepositories
{
    public CustomerWriteRepository(IECommerceDbContext context) : base(context)
    {
    }
}