using IEcommerce.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace IECommerce.Persistance.Contexts;

public class IECommerceDbContext: DbContext
{
   public IECommerceDbContext(DbContextOptions options) : base(options){}
   
   public DbSet<Product> Products { get; set; }
   public DbSet<Order> Orders { get; set; }
   public DbSet<Customer> Customers { get; set; }
   
}