using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Models
{
    public class CargoModel
    {
        public Guid IdCargo { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
