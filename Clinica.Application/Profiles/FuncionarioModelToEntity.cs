using AutoMapper;
using Clinica.Application.Models.Funcionario;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class FuncionarioModelToEntity : Profile
    {
        public FuncionarioModelToEntity()
        {
            CreateMap<FuncionarioCreateModel, Funcionario>()
                .AfterMap((src, dest) =>
                {
                    dest.IdFuncionario = Guid.NewGuid();
                    dest.IdCargo = Guid.Parse(src.IdCargo);
                });

            CreateMap<FuncionarioUpdateModel, Funcionario>();
        }
    }
}
