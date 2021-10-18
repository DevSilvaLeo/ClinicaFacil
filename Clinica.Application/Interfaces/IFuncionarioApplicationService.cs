using Clinica.Application.Models.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IFuncionarioApplicationService : IDisposable
    {
        void Create(FuncionarioCreateModel model);
        void Update(FuncionarioUpdateModel model);
        void Delete(FuncionarioDeleteModel model);

        List<FuncionarioGetModel> GetAll();
        FuncionarioGetModel GetById(Guid key);
    }
}
