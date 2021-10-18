using Adapters.SqlServer.Contexts;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Adapters.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.SqlServer.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario, Guid>, IFuncionarioRepository
    {
        private readonly SqlServerContext _context;

        public FuncionarioRepository(SqlServerContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
