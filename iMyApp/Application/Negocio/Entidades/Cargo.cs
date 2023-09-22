﻿using Negocio.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBase
    {

        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [StringLength(50)]
        [MinLength(5,ErrorMessage = "Nome muito curto")]
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Cargo(string nome, bool status) 
        {
            Nome = nome;
            Status = status;

            CriadoPor = "Miguel";
            CriadoEm = DateTime.Now;

            AlteradoPor = "Miguel";
            AlteradoEm = DateTime.Now;

        }

    }
}
