using Clinica.Application.Models.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface ICargoApplicationService : IDisposable
    {
        void Create(CargoCreateModel model);
        void Update(CargoUpdateModel model);
        void Delete(CargoDeleteModel model);

        List<CargoGetModel> GetAll();
        CargoGetModel GetById(Guid key);
    }
}
