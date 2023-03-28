using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Application.Repositories;

public interface IWriteRepositories<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddAsync(List<T> model);
    Task<bool> Remove(T model);
    Task<bool> Remove(string id);
    Task<bool> UpdateAsync(T model);
}