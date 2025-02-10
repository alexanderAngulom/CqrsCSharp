using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace Valhalla.Api.Config.Swagger;
   public static class SwaggerExtensions
    {
        public static void AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Valhalla API",
                    Version = "v1",
                    Description = "Documentación de la API de Valhalla",
                    Contact = new OpenApiContact
                    {
                        Name = "Soporte",
                        Email = "soporte@valhalla.com",
                        Url = new Uri("https://valhalla.com")
                    }
                });
            });
        }
    }
