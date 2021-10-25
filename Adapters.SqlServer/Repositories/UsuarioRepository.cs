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

        public Usuario EmailIsUnique(string email)
        {
            return _context.Set<Usuario>().Where(u => u.Login == email).FirstOrDefault();
        }

        public Usuario GetByEmailSenha(string email, string senha)
        {
            return _context.Set<Usuario>()
                .Where(u => u.Login == email)
                .Where(u => u.Senha == senha)
                .FirstOrDefault();
        }
    }
}
