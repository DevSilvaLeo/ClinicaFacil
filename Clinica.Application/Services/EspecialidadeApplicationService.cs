using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Especialidade;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class EspecialidadeApplicationService : IEspecialidadeApplicationService
    {
        private readonly IEspecialidadeDomainService _domain;
        private readonly IMapper _mapper;

        public EspecialidadeApplicationService(IEspecialidadeDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public void Create(EspecialidadeCreateModel model)
        {
            var especialidade = _mapper.Map<Especialidade>(model);
            _domain.Create(especialidade);
        }

        public void Update(EspecialidadeUpdateModel model)
        {
            var especialidade = _mapper.Map<Especialidade>(model);
            _domain.Update(especialidade);
        }

        public void Delete(EspecialidadeDeleteModel model)
        {
            var especialidade = _domain.GetById(model.Id.Value);
            _domain.Delete(especialidade);
        }

        public List<EspecialidadeGetModel> GetAll()
        {
            return _mapper.Map<List<EspecialidadeGetModel>>(_domain.GetAll());
        }

        public EspecialidadeGetModel GetById(Guid key)
        {
            return _mapper.Map<EspecialidadeGetModel>(_domain.GetById(key));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }
    }
}
