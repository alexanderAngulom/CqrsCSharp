using MediatR;

namespace Valhalla.Domain.Entities.Application.Commands;
public class CreateApplicationEventCommand(string name, string? description, Guid secret) : IRequest<CreateApplicationEventCommandResponse>
{
    public string Name { get; } = name;
    public string? Description { get; } = description;
    public Guid Secret { get; } = secret;
}

public record CreateApplicationEventCommandResponse(int id) {
    public int id { get; } = id;


    public static CreateApplicationEventCommandResponse FromResponse(int Id) {
        return new CreateApplicationEventCommandResponse(Id);
    } 
    
}