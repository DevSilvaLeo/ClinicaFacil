using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }
        public string Apelido { get; set; }

    }
}
