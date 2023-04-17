using IEcommerce.Application.Abstractions;
using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys;
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

   public async Task Get()
   {
      await _productWriteRepositories.AddAsync(new()
         { Name = "C Product", Price = 2333, Stock = 10, CreatedDate = DateTime.UtcNow });

      await _productWriteRepositories.Saveasync();
   }

   [HttpGet("{id}")]
   public async Task<IActionResult> Get(string id)
   {
      Product product = await _productReadRepositories.GetByIdAsync(id);
      return Ok(product);
   }
}