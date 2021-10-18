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
    public class ProcedimentoDomainService : BaseDomainService<Procedimento,Guid>, IProcedimentoDomainService
    {
        private readonly IProcedimentoRepository _repository;

        public ProcedimentoDomainService(IProcedimentoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
