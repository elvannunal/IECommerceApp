using IEcommerce.Domain.Entitys;
using IEcommerce.Domain.Entitys.Common;
using Microsoft.EntityFrameworkCore;

namespace IECommerce.Persistance.Contexts;

public class IECommerceDbContext: DbContext
{
   public IECommerceDbContext(DbContextOptions options) : base(options){}
   
   public DbSet<Product> Products { get; set; }
   public DbSet<Order> Orders { get; set; }
   public DbSet<Customer> Customers { get; set; }
   public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
   {
     // ChangeTracker : Enitity üzerinde yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yapakalyıp elde etmemizi sağlar.

     var datas = ChangeTracker.Entries<BaseEntity>();
     foreach (var data in datas)
     {
         _ = data.State switch
         {
             EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
             EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow
         };
     }
     return await base.SaveChangesAsync(cancellationToken);
   }
}