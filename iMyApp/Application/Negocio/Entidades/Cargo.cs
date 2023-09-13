using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cargo
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public Cargo(string nome)
        {
            Nome = nome;
        }
    }
}
