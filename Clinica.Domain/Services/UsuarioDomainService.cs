using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Adapters.Repository;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class UsuarioDomainService : BaseDomainService<Usuario,Guid>, IUsuarioDomainService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioDomainService(IUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        }

        public Usuario EmailIsUnique(string email)
        {
            return _repository.EmailIsUnique(email);
        }

        public Usuario GetByEmailSenha(string email, string senha)
        {
            return _repository.GetByEmailSenha(email, senha);
        }
    }
}
