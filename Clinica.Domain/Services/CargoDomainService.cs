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
    public class CargoDomainService : BaseDomainService<Cargo, Guid>, ICargoDomainService
    {
        private readonly ICargoRepository _repository;

        public CargoDomainService(ICargoRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
