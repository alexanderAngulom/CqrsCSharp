
using MediatR;

namespace Valhalla.Application.Entities.Application.Commands;

public record AppCreateApplicationCommand : IRequest<AppCreateApplicationEventCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public Guid Secret { get; set; }

}
public record AppCreateApplicationEventCommandResponse(int Id)
{


    public static AppCreateApplicationEventCommandResponse FromResponse(int id)
    {
        return new AppCreateApplicationEventCommandResponse(id);
    }
}


