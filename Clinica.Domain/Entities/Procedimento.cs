using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class Procedimento
    {
        public Guid IdProcedimento { get; set; }
        public string NomeProcedimento { get; set; }
        public Decimal Valor { get; set; }
    }
}
