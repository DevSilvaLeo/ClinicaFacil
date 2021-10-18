using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class Especialidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
    }
}
