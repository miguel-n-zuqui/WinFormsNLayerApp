﻿using System;
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
            return  "Server=.\\SQLEXPRESS;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;"; 
        }
    }
}