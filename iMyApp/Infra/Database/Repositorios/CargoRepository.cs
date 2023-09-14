﻿using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {
             


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

                using ( var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
              
               

            }
            catch (Exception) 
            {
                throw;
            }




           
        }
        public bool Atualizar(Cargo cargo)
        {
            try
            {

                var sql = @"            
                UPDATE[dbo].[Cargo]
                SET[Nome] = < Nome, varchar(100),>
                 ,[Status] = < Status, bit,>
                 ,[CriadoEm] = < CriadoEm, datetime,>
                 ,[CriadoPor] = < CriadoPor, varchar(50),>
                 ,[AlteradoPor] = < AlteradoPor, varchar(50),>
                 ,[AlteradoEm] = < AlteradoEm, datetime,>
                 WHERE < Search Conditions,,>";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool Deletar(int cargoId)
        {
            try
            {



                var sql = @"            
            DELETE FROM[dbo].[Cargo]
            WHERE < Search Conditions,,>";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);
                    
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable ObterTodos(int cargoId)
        {
            var sql = @"";
            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();
            try
            {



                

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    var cmd = connection.CreateCommand();
                   
                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }

            //      SELECT[Id]
            //,[Nome]
            //,[Status]
            //,[CriadoEm]
            //,[CriadoPor]
            //,[AlteradoPor]
            //,[AlteradoEm]
            //      FROM[dbo].[Cargo]
        }
    }

}
