using IEcommerce.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace IECommerce.API.Controller;

public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    // GET
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productService.GetProducts();
        return Ok(products);
    }
}