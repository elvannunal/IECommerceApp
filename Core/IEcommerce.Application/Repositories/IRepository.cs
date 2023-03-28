using IEcommerce.Domain.Entitys.Common;
using Microsoft.EntityFrameworkCore;

namespace IEcommerce.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }

}