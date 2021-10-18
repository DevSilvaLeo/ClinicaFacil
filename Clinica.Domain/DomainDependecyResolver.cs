using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain
{
    public static class DomainDependecyResolver
    {
        public static void AddDomainConfiguration(this IServiceCollection services)
        {
            services.AddTransient<ICargoDomainService, CargoDomainService>();
            services.AddTransient<IEspecialidadeDomainService, EspecialidadeDomainService>();
            services.AddTransient<IFuncionarioDomainService, FuncionarioDomainService>();
            services.AddTransient<IMedicoDomainService, MedicoDomainService>();
            services.AddTransient<IProcedimentoDomainService, ProcedimentoDomainService>();
        }
    }
}
