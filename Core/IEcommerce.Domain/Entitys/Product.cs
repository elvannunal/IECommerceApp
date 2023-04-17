using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Domain.Entitys;

public class Product:BaseEntity
{

    public string Name { get; set; }
    public int Stock { get; set; }
    public float  Price { get; set; }
        
    public ICollection<Order> Orders { get; set; }
}