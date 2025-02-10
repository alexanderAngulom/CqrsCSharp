
using MediatR;

namespace Valhalla.Application.Entities.Application.Queries.GetAllApplications;
public record AppGetAllApplicationsQuery : IRequest<AppGetAllApplicationsQueryResponse>;
public record AppGetAllApplicationsQueryResponse(List<Domain.Entities.Application.Application> Applications)
{
    public static AppGetAllApplicationsQueryResponse FromResponse(List<Domain.Entities.Application.Application> applications)
    {
        return new AppGetAllApplicationsQueryResponse(applications);
    }
}
