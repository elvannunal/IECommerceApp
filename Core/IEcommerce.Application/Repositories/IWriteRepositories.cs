using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Application.Repositories;

public interface IWriteRepositories<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T datas);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T datas);
    bool RemoveRange(List<T> datas);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> Saveasync();
}