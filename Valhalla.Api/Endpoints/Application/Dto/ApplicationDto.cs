namespace Valhalla.Api.Endpoints.Application.Dto;

public record ApplicationDto(string Name, string? Description, Guid Secret){
    public static ApplicationDto FromResponse(string name, string? description, Guid secret){
        return new ApplicationDto(name, description, secret);
    }
}