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
    public class MedicoModelToEntity : Profile
    {
        public MedicoModelToEntity()
        {
            CreateMap<MedicoCreateModel, Medico>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.NewGuid();
                    dest.DataEmissao = Convert.ToDateTime(src.DataEmissao);
                    dest.DataValidade = Convert.ToDateTime(src.DataValidade);
                    dest.IdFuncionario = Guid.Parse(src.IdFuncionario);
                });
        }
    }
}
