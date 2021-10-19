using Adapters.SqlServer.Mappings;
using Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.SqlServer.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext>options)
            : base(options)
        {

        }

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Procedimento> Procedimento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new CargoMap());
            modelbuilder.ApplyConfiguration(new EspecialidadeMap());
            modelbuilder.ApplyConfiguration(new FuncionarioMap());
            modelbuilder.ApplyConfiguration(new MedicoMap());
            modelbuilder.ApplyConfiguration(new ProcedimentoMap());
            modelbuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
