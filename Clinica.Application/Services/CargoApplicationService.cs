using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Cargo;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class CargoApplicationService : ICargoApplicationService
    {
        private readonly ICargoDomainService _domain;
        private readonly IMapper _mapper;

        public CargoApplicationService(ICargoDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }


        public void Create(CargoCreateModel model)
        {
            var cargo = _mapper.Map<Cargo>(model);
            _domain.Create(cargo);
        }

        public void Update(CargoUpdateModel model)
        {
            var cargo = _mapper.Map<Cargo>(model);
            _domain.Update(cargo);
        }

        public void Delete(CargoDeleteModel model)
        {
            var cargo = _domain.GetById(model.IdCargo.Value);
            _domain.Delete(cargo);
        }

        public List<CargoGetModel> GetAll()
        {
            return _mapper.Map<List<CargoGetModel>>(_domain.GetAll());
        }

        public CargoGetModel GetById(Guid key)
        {
            return _mapper.Map<CargoGetModel>(_domain.GetById(key));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }
    }
}
