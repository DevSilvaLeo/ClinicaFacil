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
    public class EspecialidadeRepository : BaseRepository<Especialidade, Guid>, IEspecialidadeRepository
    {
        private readonly SqlServerContext _context;

        public EspecialidadeRepository(SqlServerContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
