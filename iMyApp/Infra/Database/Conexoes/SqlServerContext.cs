using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica com a string 
    /// de conexão com SqlServer
    /// </summary>
    internal static class SqlServerContext
    {
        /// <summary>
        /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
        /// </summary>
        internal static string Conexao => ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
    //Obs.: Repare que o ConfigurationManager acessa o App.Config e busca uma ConnectionString Name chamada "SqlServer".
}
