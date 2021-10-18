using AutoMapper;
using Clinica.Application.Models.Especialidade;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class EspecialidadeEntityToModel : Profile
    {
        public EspecialidadeEntityToModel()
        {
            CreateMap<Especialidade, EspecialidadeGetModel>();
        }
    }
}
