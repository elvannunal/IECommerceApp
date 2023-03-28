using IEcommerce.Application.Abstractions;
using IEcommerce.Domain.Entitys;

namespace IECommerce.Persistance.Concrate;

public class ProductService:IProductService
{
    public List<Product> GetProducts() => new()
    {
        new(){Id=Guid.NewGuid(),Name="Product1", Price = 10,Stock = 100},
        new(){Id=Guid.NewGuid(),Name="Product2", Price = 20,Stock = 200},
        new(){Id=Guid.NewGuid(),Name="Product3", Price = 30,Stock = 300}
    };
}