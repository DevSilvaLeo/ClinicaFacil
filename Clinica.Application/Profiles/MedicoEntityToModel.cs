using AutoMapper;
using Clinica.Application.Models.Medico;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class MedicoEntityToModel : Profile
    {
        public MedicoEntityToModel()
        {
            CreateMap<Medico, MedicoGetModel>();
        }
    }
}
