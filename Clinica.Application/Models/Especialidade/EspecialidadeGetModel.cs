using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Models.Especialidade
{
    public class EspecialidadeGetModel
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
    }
}
