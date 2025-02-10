

namespace Valhalla.Infrastructure.EntityFramework.Entities.Application;
public class ApplicationTenat
{
    public int ApplicationsId { get; set; }
    public Application Application { get; set; } = default!;
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = default!;
}
