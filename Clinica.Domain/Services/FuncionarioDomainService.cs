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
    public class FuncionarioDomainService : BaseDomainService<Funcionario,Guid>, IFuncionarioDomainService
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioDomainService(IFuncionarioRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
