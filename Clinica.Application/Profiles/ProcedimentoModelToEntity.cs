using AutoMapper;
using Clinica.Application.Models;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class ProcedimentoModelToEntity : Profile
    {
        public ProcedimentoModelToEntity()
        {
            CreateMap<ProcedimentoCreateModel, Procedimento>()
                .AfterMap((src, dest) =>
                {
                    dest.IdProcedimento = Guid.NewGuid();
                    dest.Valor = Convert.ToDecimal(src.Valor);
                });
        }
    }
}
