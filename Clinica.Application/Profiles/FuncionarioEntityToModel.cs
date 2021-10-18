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
    public class FuncionarioEntityToModel : Profile
    {
        public FuncionarioEntityToModel()
        {
            CreateMap<FuncionarioGetModel, Funcionario>();
        }
    }
}
