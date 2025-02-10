using MediatR;
using Valhalla.Domain.Entities.Application.Repository.Application;

namespace Valhalla.Domain.Entities.Application.Commands;
public class CreateApplicationEventCommandHandler(IApplicationRepository repository) : IRequestHandler<CreateApplicationEventCommand, CreateApplicationEventCommandResponse>
{


    async Task<CreateApplicationEventCommandResponse> IRequestHandler<CreateApplicationEventCommand, CreateApplicationEventCommandResponse>.Handle(CreateApplicationEventCommand request, CancellationToken cancellationToken)
    {
        var application = new Application
        {
            Name = request.Name,
            Description = request.Description,
            Secret = request.Secret
        };

        var applicationCreated = await repository.CreateApplicationAsync(application);
        return CreateApplicationEventCommandResponse.FromResponse(applicationCreated);
    }
}

