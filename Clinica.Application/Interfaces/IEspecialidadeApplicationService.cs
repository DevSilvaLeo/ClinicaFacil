using Clinica.Application.Models.Especialidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IEspecialidadeApplicationService : IDisposable
    {
        void Create(EspecialidadeCreateModel model);
        void Update(EspecialidadeUpdateModel model);
        void Delete(EspecialidadeDeleteModel model);

        List<EspecialidadeGetModel> GetAll();
        EspecialidadeGetModel GetById(Guid key);
    }
}
