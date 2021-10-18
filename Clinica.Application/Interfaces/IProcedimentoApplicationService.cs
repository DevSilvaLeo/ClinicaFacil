using Clinica.Application.Models.Procedimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IProcedimentoApplicationService : IDisposable
    {
        void Create(ProcedimentoCreateModel model);
        void Update(ProcedimentoUpdateModel model);
        void Delete(ProcedimentoDeleteModel model);
        List<ProcedimentoGetModel> GetAll();
        ProcedimentoGetModel GetById(Guid key);
    }
}
