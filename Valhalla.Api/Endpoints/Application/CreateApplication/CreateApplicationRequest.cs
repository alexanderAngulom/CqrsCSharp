using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla.Api.Endpoints.Application.CreateApplication;

public record CreateApplicationRequestResponse(int Id)
{
    public static CreateApplicationRequestResponse fromResponse(int id)
    { 
        return new CreateApplicationRequestResponse(id);
    }
}
