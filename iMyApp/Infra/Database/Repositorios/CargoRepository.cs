using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{

    /// <summary>
    /// <c>CargoRepository</c> - Executa comando SQL (CRUD) na tabela de [dbo].[Cargo]
    /// <exemple>Exemplo:
    ///         var repositorio = new CargoRepository();
    /// </exemple>
    /// </summary>
    public class CargoRepository
    {
        /// <summary>
        /// Insere um novo regiistro na tabela Cargo
        /// <exemple>Exemplo:
        ///    <code>
        ///    var cargoRepositorio = new CargoRepository();
        ///    var cargo = new Cargo("nome,"Status");
        ///    var resultado = cargoRepositorio.Inserir(cargo);
        ///    </code>
        /// </exemple>
        /// </summary>
        /// <param name="cargo">Entidade Cargo</param>
        /// <returns>true ou falso</returns>
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
                 (@Nome,
                 @Status,
                 @CriadoEm, 
                 @CriadoPor,
                 @AlteradoPor,
                 @AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nome", cargo.Nome);
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
        public bool Atualizar(Cargo cargo, int id)
        {
            try
            {

                var sql = @"UPDATE [dbo].[Cargo]
                   SET [Nome] = @nome
                  ,[Status] = @Status
                  ,[AlteradoEm] = @AlteradoEm
                  ,[AlteradoPor] = @AlteradoPor
                   WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }



            }
            catch (Exception)
            {
                throw;
            }

        }
        public bool Deletar(int cargoId)
        {
            try
            {



                var sql = @"            
                            DELETE FROM[dbo].[Cargo]
                            WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }



            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable ObterTodos()
        {
            var sql = @"SELECT [Id],[Nome],[Status],[AlteradoEm] FROM [dbo].[Cargo]";
            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();
            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
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

        public List<string> Complemento(string cargo)
        {
            var sql = @"SELECT [Nome] FROM [dbo].[Cargo]";

            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);

                    SqlDataReader reader = com.ExecuteReader();

                    var lista = new List<string>();

                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0).Trim());
                    }
                    
                    return lista;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}


