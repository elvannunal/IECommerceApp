using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys.Common;
using IECommerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace IECommerce.Persistance.Repositories;

public class WriteRepositories<T> : IWriteRepositories<T> where T : BaseEntity
{
    readonly private IECommerceDbContext _context;
    
    public WriteRepositories(IECommerceDbContext context)
    {
        _context= context;
    }
    
    public DbSet<T> Table { get; }
    public async Task<bool> AddAsync(T datas)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(datas);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> datas)
    {
        await Table.AddRangeAsync();
        return true;
    }

    public bool Remove(T datas)
    {
        EntityEntry<T> entityEntry = Table.Remove(datas);
        return entityEntry.State == EntityState.Deleted;

    }

    public bool RemoveRange(List<T> datas)
    {
        Table.RemoveRange(datas);
        return true;
    }

    public async Task<bool> RemoveAsync  (string id)
    {
        T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(model);
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }


    public async Task<int> Saveasync()
        => await _context.SaveChangesAsync();
}