using Negocio.Entidades;
using Negocio.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    //clientes herda os dados de pessoas
    public class Cliente : Pessoa
    {
        public DateTime Nascimento { get; set; }

    }
}
