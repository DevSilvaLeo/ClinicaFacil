using Adapters.SqlServer.Contexts;
using Adapters.SqlServer.Repositories;
using Clinica.Domain.Interfaces.Adapters.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.SqlServer
{
    public static class SqlDependecyResolver
    {
        public static void AddSqlServerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlServerContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("ClinicaApp")));

            services.AddTransient<ICargoRepository, CargoRepository>();
            services.AddTransient<IEspecialidadeRepository, EspecialidadeRepository>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IProcedimentoRepository, ProcedimentoRepository>();
        }
    }
}
