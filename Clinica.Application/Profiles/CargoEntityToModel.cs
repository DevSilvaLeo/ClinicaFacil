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
    public class CargoEntityToModel : Profile
    {
        public CargoEntityToModel()
        {
            CreateMap<Cargo, CargoGetModel>();
        }
    }
}
