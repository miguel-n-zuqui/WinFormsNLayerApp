using Database.Conexoes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class AutoComplemento
    {
        public string Nome { get; set; }

        public AutoComplemento(string nome) { Nome = nome; }

    }
}
