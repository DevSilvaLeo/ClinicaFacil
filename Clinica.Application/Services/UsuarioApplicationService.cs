using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.Models.Usuario;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioDomainService _domain;
        private readonly IMapper _mapper;

        public UsuarioApplicationService(IUsuarioDomainService domain, IMapper mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public void Create(UsuarioCreateModel model)
        {
            var usuario = _mapper.Map<Usuario>(model);
            _domain.Create(usuario);
        }        

        public void Update(UsuarioUpdateModel model)
        {
            var usuario = _mapper.Map<Usuario>(model);
            _domain.Update(usuario);
        }

        public void Delete(UsuarioDeleteModel model)
        {
            var usuario = _domain.GetById(model.Id.Value);
            _domain.Delete(usuario);
        }

        public List<UsuarioGetModel> GetAll()
        {
            return _mapper.Map<List<UsuarioGetModel>>(_domain.GetAll());
        }

        public UsuarioGetModel GetById(Guid key)
        {
            return _mapper.Map<UsuarioGetModel>(_domain.GetById(key));
        }
        public UsuarioGetModel EmailIsUnique(string key)
        {
            return _mapper.Map<UsuarioGetModel>(_domain.EmailIsUnique(key));
        }
        public UsuarioGetModel GetByLoginSenha(string key, string password)
        {
            return _mapper.Map<UsuarioGetModel>(_domain.GetByEmailSenha(key, password));
        }

        public void Dispose()
        {
            _domain.Dispose();
        }

    }
}
