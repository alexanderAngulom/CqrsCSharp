using MediatR;
using Valhalla.Domain.Entities.Application.Commands;

namespace Valhalla.Application.Entities.Application.Commands;
public class AppCreateApplicationCommandHandler (IMediator mediator): IRequestHandler<AppCreateApplicationCommand, AppCreateApplicationEventCommandResponse>
{

    public async Task<AppCreateApplicationEventCommandResponse> Handle(AppCreateApplicationCommand request, CancellationToken cancellationToken)
    {
        var response=await mediator.Send(new CreateApplicationEventCommand(request.Name,request.Description,request.Secret), cancellationToken);
        
        return AppCreateApplicationEventCommandResponse.FromResponse(response.id);    

    }
}

