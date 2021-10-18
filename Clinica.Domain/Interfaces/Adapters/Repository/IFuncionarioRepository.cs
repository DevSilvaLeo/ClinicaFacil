using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Interfaces.Adapters.Repository
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario,Guid>
    {
    }
}
