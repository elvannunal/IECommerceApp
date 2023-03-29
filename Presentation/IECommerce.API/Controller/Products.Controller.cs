using IEcommerce.Application.Abstractions;
using IEcommerce.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IECommerce.API.Controller;

public class ProductsController : ControllerBase
{
   readonly private IProductWriteRepositories _productWriteRepositories;
   readonly private IProductReadRepositories _productReadRepositories;

   public ProductsController(IProductWriteRepositories productWriteRepositories,
      IProductReadRepositories productReadRepositories)
   {
      _productReadRepositories = productReadRepositories;
      _productWriteRepositories = productWriteRepositories;
   }

   [HttpGet]

   public async void Get()
   {
      await _productWriteRepositories.AddRangeAsync(new()
      {
         new() { Id = Guid.NewGuid(), Name = "Product1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
         new() { Id = Guid.NewGuid(), Name = "Product1", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20 },
         new() { Id = Guid.NewGuid(), Name = "Product1", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 30 }
      });
      var count = await _productWriteRepositories.Saveasync();
   }
}