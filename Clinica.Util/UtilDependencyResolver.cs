using Clinica.Util.Cripto;
using Clinica.Util.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Util
{
    public static class UtilDependencyResolver
    {
        public static void AddApplicationConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IMD5Criptography, Cryptography>();
        }
    }
}
