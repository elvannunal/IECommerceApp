using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Domain.Entitys;

public class Order:BaseEntity
{
    public int? Customerid { get; set; }
    public int? Description { get; set; }
    public string Address { get; set; }
    public ICollection<Product> Products { get; set; }
    public Customer Customer { get; set; }
    
}