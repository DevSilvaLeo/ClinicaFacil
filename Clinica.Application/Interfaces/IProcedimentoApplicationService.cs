using Clinica.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IProcedimentoApplicationService
    {
        void Create(ProcedimentoCreateModel model);
    }
}
