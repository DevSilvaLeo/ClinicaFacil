using Clinica.Application.Models.Medico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IMedicoApplicationService : IDisposable
    {
        void Create(MedicoCreateModel model);
        void Update(MedicoUpdateModel model);
        void Delete(MedicoDeleteModel model);

        List<MedicoGetModel> GetAll();
        MedicoGetModel GetById(Guid key);
    }
}
