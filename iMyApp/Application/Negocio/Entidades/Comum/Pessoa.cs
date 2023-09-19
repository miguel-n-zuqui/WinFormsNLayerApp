using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Comum
{
    public class Pessoa : EntidadeBase
    {
        public int Id { get; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

    }
}
