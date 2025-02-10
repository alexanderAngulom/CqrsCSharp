namespace Valhalla.Domain.Entities.Application;
public class Tenant
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string>? Callbacks { get; set; }
    public List<string>? Audience { get; set; }
}