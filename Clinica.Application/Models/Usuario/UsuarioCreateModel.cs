﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Models.Usuario
{    
    public class UsuarioCreateModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }
        public string Apelido { get; set; }
    }
}
