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
    public class EspecialidadeDomainService : BaseDomainService<Especialidade,Guid>, IEspecialidadeDomainService
    {
        private readonly IEspecialidadeRepository _repository;

        public EspecialidadeDomainService(IEspecialidadeRepository repository)
           : base(repository)
        {
            _repository = repository;
        }
    }
}
