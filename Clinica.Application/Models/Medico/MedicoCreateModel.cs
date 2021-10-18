﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Models.Medico
{
    public class MedicoCreateModel
    {
        public string Especialidade { get; set; }
        public string NumeroCarteira { get; set; }
        public string NomeConselho { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataEmissao { get; set; }
        public string IdFuncionario { get; set; }
    }
}
