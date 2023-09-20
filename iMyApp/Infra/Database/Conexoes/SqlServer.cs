using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe de estatica com a string de conexao
    /// </summary>
    internal class SqlServer
    {
        /// <summary>
        /// Metodo que <c>StrConexaoHardCore()</c> retorna a string de conexao sql
        /// </summary>
        /// <returns> string: ConnextionString</returns>
        internal static string StrConexaoHardCore()
        {

            return "Server=.\\SQLEXPRESS;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";

        }

    }
}
