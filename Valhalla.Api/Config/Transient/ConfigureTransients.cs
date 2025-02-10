
using System.Reflection;

namespace Valhalla.Api.Config.Transient;

public static class ConfigureTransients
{
    public static void AddRepositories(this IServiceCollection services)
    {
        var domainAssembly = Assembly.Load("Valhalla.Domain");
        var infrastructureAssembly = Assembly.Load("Valhalla.Infrastructure");

        var repositoryTypes = infrastructureAssembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Repository"))
            .ToList();

        foreach (var implementationType in repositoryTypes)
        {
            var interfaceType = domainAssembly.GetTypes()
                .FirstOrDefault(i => i.IsInterface && "I" + implementationType.Name == i.Name);

            if (interfaceType != null)
            {
                services.AddScoped(interfaceType, implementationType);
            }
        }
    }

}