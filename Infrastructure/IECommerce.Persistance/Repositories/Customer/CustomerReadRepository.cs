using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
using IECommerce.Persistance.Contexts;

namespace IECommerce.Persistance.Repositories;

public class CustomerReadRepository: ReadRepositories<Customer>, ICustomerReadRepositories
{
    public CustomerReadRepository(IECommerceDbContext context) : base(context)
    {
    }
}