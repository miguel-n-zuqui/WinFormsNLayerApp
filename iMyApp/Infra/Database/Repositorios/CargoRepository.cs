using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public int Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StrConexaoHardCore();
            var sqlConnection = new SqlConnection(stringConexao);
            sqlConnection.Open();


            var sql = @"INSERT INTO [dbo].[Cargo]
                  ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
              VALUES
                 (<@Nome,
                 ,<@Status,
                 ,<@CriadoEm, 
                 ,<@CriadoPor,
                 ,<@AlteradoPor,
                 ,<@AlteradoEm)";

            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome", cargo.Nome);
            cmd.Parameters.AddWithValue("@Status", cargo.Status);
            cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
            cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
            cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
            cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
            
            sqlConnection.Close();
        }
    }
}
