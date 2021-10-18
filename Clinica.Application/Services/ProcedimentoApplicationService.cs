using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models;
using Clinica.Application.Models.Procedimento;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class ProcedimentoApplicationService : IProcedimentoApplicationService
    {
        private readonly IProcedimentoDomainService _domain;
        private readonly IMapper _mapper;


        public ProcedimentoApplicationService(IProcedimentoDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public void Create(ProcedimentoCreateModel model)
        {
            var procedimento =_mapper.Map<Procedimento>(model);
            _domain.Create(procedimento);
        }

        public void Update(ProcedimentoUpdateModel model)
        {
            var procedimento = _mapper.Map<Procedimento>(model);
            _domain.Update(procedimento);
        }

        public void Delete(ProcedimentoDeleteModel model)
        {
            var procedimento = _domain.GetById(model.IdProcedimento.Value);
            _domain.Delete(procedimento);
        }

        public List<ProcedimentoGetModel> GetAll()
        {
            return _mapper.Map<List<ProcedimentoGetModel>>(_domain.GetAll());
        }

        public ProcedimentoGetModel GetById(Guid key)
        {
            return _mapper.Map<ProcedimentoGetModel>(_domain.GetById(key));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }
    }
}
