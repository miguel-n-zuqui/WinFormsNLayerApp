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
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Genero { get; set; }
        public bool Status { get; set; }
        public string EnderecoEstado { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string Nacionalidade { get; set; }
        public string EstadoCivil { get; set; }

    }
}
