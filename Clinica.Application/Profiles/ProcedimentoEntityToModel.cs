using AutoMapper;
using Clinica.Application.Models.Procedimento;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class ProcedimentoEntityToModel : Profile
    {
        public ProcedimentoEntityToModel()
        {
            CreateMap<Procedimento, ProcedimentoGetModel>();
        }
    }
}
