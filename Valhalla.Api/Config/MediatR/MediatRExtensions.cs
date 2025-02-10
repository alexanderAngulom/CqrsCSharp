using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Linq;
using System.Reflection;

namespace Valhalla.Api.Config.MediatR
{
    public static class MediatRExtensions
    {
        public static void AddMediatRHandlers(this IServiceCollection services)
        {
            var applicationAssembly = Assembly.Load("Valhalla.Application") ?? throw new InvalidOperationException("No se pudo cargar el ensamblado Valhalla.Application.");
            var domainAssembly = Assembly.Load("Valhalla.Domain") ?? throw new InvalidOperationException("No se pudo cargar el ensamblado Valhalla.Domain.");
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(applicationAssembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(domainAssembly));
        }
    }
}
