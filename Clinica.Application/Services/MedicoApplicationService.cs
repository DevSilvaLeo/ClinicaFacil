using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models;
using Clinica.Application.Models.Medico;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class MedicoApplicationService : IMedicoApplicationService
    {
        private readonly IMedicoDomainService _domain;
        private readonly IMapper _mapper;

        public MedicoApplicationService(IMedicoDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public void Create(MedicoCreateModel model)
        {
            var medico = _mapper.Map<Medico>(model);
            _domain.Create(medico);
        }

        public void Update(MedicoUpdateModel model)
        {
            var medico = _mapper.Map<Medico>(model);
            _domain.Update(medico);
        }

        public void Delete(MedicoDeleteModel model)
        {
            var medico = _domain.GetById(model.Id.Value);
            _domain.Delete(medico);
        }

        public List<MedicoGetModel> GetAll()
        {
            return _mapper.Map<List<MedicoGetModel>>(_domain.GetAll());
        }

        public MedicoGetModel GetById(Guid key)
        {
            return _mapper.Map<MedicoGetModel>(_domain.GetById(key));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }
    }
}
