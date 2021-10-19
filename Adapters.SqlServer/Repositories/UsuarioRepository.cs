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
    public class UsuarioRepository : BaseRepository<Usuario, Guid>, IUsuarioRepository
    {
        private readonly SqlServerContext _context;

        public UsuarioRepository(SqlServerContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
