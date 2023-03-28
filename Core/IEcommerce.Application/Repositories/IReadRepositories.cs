using System.Linq.Expressions;
using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Application.Repositories;


public interface IReadRepositories<T> :IRepository<T> where T : BaseEntity
{
   IQueryable<T> GetAll();
   IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
   T GetSingleAsync(Expression<Func<T, bool>> method);
   T GetByIdAsync(string id);
}