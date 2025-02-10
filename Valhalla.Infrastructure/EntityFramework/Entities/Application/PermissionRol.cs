using Valhalla.Infrastructure.EntityFramework.Implements.Repository.Permissions;

namespace Valhalla.Infrastructure.EntityFramework.Entities.Application;

public class PermissionRol
{
    public int RolesId { get; set; }
    public Rol Rol { get; set; } = default!;
    public int PermissionsId { get; set; }
    public Permissions Permission { get; set; } = default!;


}
