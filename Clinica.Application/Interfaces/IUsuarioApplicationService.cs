using Clinica.Application.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IUsuarioApplicationService : IDisposable
    {
        void Create(UsuarioCreateModel model);
        void Update(UsuarioUpdateModel model);
        void Delete(UsuarioDeleteModel model);
        List<UsuarioGetModel> GetAll();
        UsuarioGetModel GetById(Guid key);
        UsuarioGetModel GetByLoginSenha(string login, string password);
    }
}
