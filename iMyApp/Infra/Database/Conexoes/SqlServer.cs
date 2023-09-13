using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    internal class SqlServer
    {
        internal static string StrConexaoHardCore()
        {
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=iMyApp;User ID=sa;Password=sql2022";
        }
    }
}
