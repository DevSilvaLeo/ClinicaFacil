using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Interfaces.Adapters.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario,Guid>
    {
        Usuario GetByEmailSenha(string email, string senha);
        Usuario EmailIsUnique(string email);
    }
}
