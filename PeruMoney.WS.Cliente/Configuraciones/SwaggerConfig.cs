using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace PeruMoney.WS.Cliente.Configuraciones
{
    public static class SwaggerConfig
    {
        public static void AgregarSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";
                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"PeruMoney {groupName}",
                    Version = groupName,
                    Description = "MarketFriend API",
                    Contact = new OpenApiContact
                    {
                        Name = "Perú Money.",
                        Email = "perumoney@perumoney.com",
                        Url = new Uri("https://perumoney.com")
                    }
                });
                options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Scheme = "bearer"
                });
                options.OperationFilter<AuthenticationRequirementsOperationFilter>();
            });
        }
    }
}
