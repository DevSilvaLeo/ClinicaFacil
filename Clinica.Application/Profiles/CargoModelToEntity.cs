using AutoMapper;
using Clinica.Application.Models.Cargo;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class CargoModelToEntity : Profile
    {
        public CargoModelToEntity()
        {
            CreateMap<CargoCreateModel, Cargo>()
                .AfterMap((src, dest) =>
                {
                    dest.IdCargo = Guid.NewGuid();
                    dest.DataCadastro = DateTime.Now;                    
                });

            CreateMap<CargoUpdateModel, Cargo>();
        }
    }
}
