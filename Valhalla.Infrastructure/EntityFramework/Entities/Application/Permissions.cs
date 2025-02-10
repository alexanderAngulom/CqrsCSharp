
namespace Valhalla.Infrastructure.EntityFramework.Entities.Application;

public class Permissions
{
    public int Id { get; init; }
    public int ApplicationId { get; set; }
    public Application Application { get; set; } = default!;
    public required string Name { get; set; }
    public string? Description { get; set; } = string.Empty;
    public bool IsActive { set; get; }
}
