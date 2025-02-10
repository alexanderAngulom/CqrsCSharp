using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using MediatR;
using Valhalla.Domain.Entities.Application.Repository.Application;

namespace Valhalla.Domain.Entities.Application.Queries
{
    public class GetAllApplicationsQueryHandler(IApplicationRepository repository) : IRequestHandler<GetAllApplicationsQuery, GetAllApplicationsQueryResponse>
    {
        public async Task<GetAllApplicationsQueryResponse> Handle(GetAllApplicationsQuery request, CancellationToken cancellationToken)
        {
            var applications = await repository.GetAllApplicationsAsync();
            return GetAllApplicationsQueryResponse.FromResponse(applications);
        }
    }
}