﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    internal class Usuario
    {
        public  string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; internal set; }
    }
}
