using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapters.Api
{
    public static class ApiDependencyResolver
    {
        public static void AddApiConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API de serviços Clinica Fácil",
                    Description = "API com os serviços do sistema de clinicas",
                    Contact = new OpenApiContact
                    {
                        Name = "The One Software",
                        Email = "contato@theonesoftware.com.br",
                        Url = new Uri("http://www.theonesoftware.com.br")
                    }
                });
                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme.Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                s.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header,
                            },
                            new List<string>()
                        }
                });
            });
        }
        public static void UseApiConfiguration(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyProject");
            });
        }
    }
}
