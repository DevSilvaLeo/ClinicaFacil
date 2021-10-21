using AutoMapper;
using Clinica.Application.Models.Usuario;
using Clinica.Application.Security.Cripto;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Profiles
{
    public class UsuarioModelToEntity : Profile
    {

        public UsuarioModelToEntity()
        {
            var cripto = new CriptoService();

            CreateMap<UsuarioCreateModel, Usuario>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.NewGuid();
                    dest.Senha = cripto.Ecrypt(src.Senha);
                });

            CreateMap<UsuarioUpdateModel, Usuario>();
        }
    }
}
