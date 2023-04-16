using IEcommerce.Domain.Entitys.Common;

namespace IEcommerce.Domain.Entitys;

public class Agency: BaseEntity
{
    public Guid AgencyId { get; set; }
    public int AgencyName { get; set; }
}