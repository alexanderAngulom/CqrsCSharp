using MediatR;
using Valhalla.Domain.Entities.Application.Queries;

namespace Valhalla.Application.Entities.Application.Queries.GetAllApplications;
public class AppGetAllApplicationsQueryHanlder (IMediator mediator): IRequestHandler<AppGetAllApplicationsQuery, AppGetAllApplicationsQueryResponse>
{
    public async Task<AppGetAllApplicationsQueryResponse> Handle(AppGetAllApplicationsQuery request, CancellationToken cancellationToken)
    {
      try
      {
        var result = await mediator.Send(new GetAllApplicationsQuery(), cancellationToken);
        return AppGetAllApplicationsQueryResponse.FromResponse(result.Applications);
      }
      catch (System.Exception)
      {
        
        throw;
      }
    }
}
