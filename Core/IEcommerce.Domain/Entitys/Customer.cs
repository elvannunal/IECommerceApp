using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Domain.Entitys;

public class Customer : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Order> Order{ get; set; }
}