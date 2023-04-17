using System.Linq.Expressions;
using IEcommerce.Application.Repositories;
using IEcommerce.Domain.Entitys.Common;
using IECommerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IECommerce.Persistance.Repositories;

public class ReadRepositories<T> : IReadRepositories<T> where  T : BaseEntity
{
    private readonly IECommerceDbContext _context;

    public ReadRepositories(IECommerceDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method);
        if(!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(method);
    }

    public async Task<T> GetByIdAsync(string id,bool tracking = true)
        // => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
       // => await Table.FindAsync(id);
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }

}