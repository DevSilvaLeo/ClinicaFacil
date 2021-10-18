using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Funcionario;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class FuncionarioApplicationService : IFuncionarioApplicationService
    {
        private readonly IFuncionarioDomainService _domain;
        private readonly IMapper _mapper;


        public FuncionarioApplicationService(IFuncionarioDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public void Create(FuncionarioCreateModel model)
        {
            var funcionario = _mapper.Map<Funcionario>(model);
            _domain.Create(funcionario);
        }

        public void Update(FuncionarioUpdateModel model)
        {
            var funcionario = _mapper.Map<Funcionario>(model);
            _domain.Update(funcionario);
        }

        public void Delete(FuncionarioDeleteModel model)
        {
            var funcionario = _domain.GetById(model.IdFuncionario.Value);
            _domain.Delete(funcionario);
        }

        public List<FuncionarioGetModel> GetAll()
        {
            return _mapper.Map<List<FuncionarioGetModel>>(_domain.GetAll());
        }

        public FuncionarioGetModel GetById(Guid key)
        {
            return _mapper.Map<FuncionarioGetModel>(_domain.GetById(key));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }
    }
}
