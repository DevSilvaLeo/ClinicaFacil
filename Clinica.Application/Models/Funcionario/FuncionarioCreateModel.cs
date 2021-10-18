using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Models.Funcionario
{
    public class FuncionarioCreateModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string IdCargo { get; set; }
    }
}
