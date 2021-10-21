using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Security.Interfaces
{
    public interface ICriptoService
    {
        string Ecrypt(string value);
    }
}
