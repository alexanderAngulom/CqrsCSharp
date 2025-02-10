using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Valhalla.Api.Endpoints.Application.Dto;
using Valhalla.Application.Entities.Application.Queries.GetAllApplications;

namespace Vanhala.API.Endpoints.Application.GetAllApplications;

[Route("api/applications")]
[ApiController]
public class GetAllApplicationsQueryRequestHandler(IMediator mediator) : ControllerBase
{
    [HttpGet("getall")]
    public async Task<ActionResult<List<ApplicationDto>>> GetAllApplications()
    {
        var result = await mediator.Send(new AppGetAllApplicationsQuery());

        if (result == null || result.Applications == null || !result.Applications.Any())
        {
            return NotFound("No se encontraron aplicaciones.");
        }

        var response = result.Applications.Select(x => new ApplicationDto(
            x.Name,
            x.Description,
            x.Secret
        )).ToList();

        return Ok(response); 
    }
}
