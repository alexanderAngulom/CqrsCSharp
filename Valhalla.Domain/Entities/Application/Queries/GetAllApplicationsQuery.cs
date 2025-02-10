using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;

namespace Valhalla.Domain.Entities.Application.Queries
{
    public record GetAllApplicationsQuery: IRequest<GetAllApplicationsQueryResponse>;
    public record GetAllApplicationsQueryResponse(List<Application> Applications)
    {
        public static GetAllApplicationsQueryResponse FromResponse(List<Application> applications) {
            return new GetAllApplicationsQueryResponse(applications);
        }
    }
}