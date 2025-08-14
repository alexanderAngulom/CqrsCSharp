
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Valhalla.Application.Entities.Application.Commands;

namespace Valhalla.Api.Endpoints.Application.CreateApplication;

[Route("api/applications")]
[ApiController]
public class CreateApplicationController(IMediator mediator) : ControllerBase
{
    [HttpPost("create")]
    public async Task<ActionResult<CreateApplicationRequestResponse>> CreateApplication(
        [FromBody] AppCreateApplicationCommand command
    )
    {
        var result = await mediator.Send(command);
        var response = CreateApplicationRequestResponse.fromResponse(result.Id);
        return Ok(response);
    }
}
