
using Valhalla.Domain.Entities.Application;

namespace Valhalla.Domain.Entities.User;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime? LastAuthenticationDate { get; set; }
    public List<Rol> Roles { get; set; } = [];
    public Tenant TenantItem { get; set; } = default!;
}
