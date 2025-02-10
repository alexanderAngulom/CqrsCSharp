namespace Valhalla.Domain.Entities.Application;

public class Application
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public Guid Secret { get; set; }
    public List<Rol> Roles { get; set; } = [];
    public List<Permissions> Permissions { get; set; } = [];
    public List<Tenant> TenantItems { get; set; } = [];


}
