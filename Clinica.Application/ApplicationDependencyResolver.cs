using Clinica.Application.Interfaces;
using Clinica.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application
{
    public static class ApplicationDependencyResolver
    {
        public static void AddApplicationConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<ICargoApplicationService, CargoApplicationService>();
            services.AddTransient<IEspecialidadeApplicationService, EspecialidadeApplicationService>();
            services.AddTransient<IFuncionarioApplicationService, FuncionarioApplicationService>();
            services.AddTransient<IMedicoApplicationService, MedicoApplicationService>();
            services.AddTransient<IProcedimentoApplicationService, ProcedimentoApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
        }
    }
}
