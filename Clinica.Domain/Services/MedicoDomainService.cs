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
    public class MedicoDomainService : BaseDomainService<Medico, Guid>, IMedicoDomainService
    {
        private readonly IMedicoRepository _repository;

        public MedicoDomainService(IMedicoRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
