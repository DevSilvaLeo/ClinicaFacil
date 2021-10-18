using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Models.Procedimento
{
    public class ProcedimentoGetModel
    {
        public Guid? IdProcedimento { get; set; }
        public string NomeProcedimento { get; set; }
        public Decimal Valor { get; set; }
    }
}
