

namespace Valhalla.Domain.Entities.Application;
public class Rol
{

    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<Permissions> Permissions { get; set; }=[];
}
