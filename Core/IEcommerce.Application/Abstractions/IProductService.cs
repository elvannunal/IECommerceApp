using IEcommerce.Domain.Entitys;

namespace IEcommerce.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}