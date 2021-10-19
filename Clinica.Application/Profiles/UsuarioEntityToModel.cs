using AutoMapper;
using Clinica.Application.Models.Usuario;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class UsuarioEntityToModel : Profile
    {
        public UsuarioEntityToModel()
        {
            CreateMap<Usuario, UsuarioGetModel>();
        }
    }
}
