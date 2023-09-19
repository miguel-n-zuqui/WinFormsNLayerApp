using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Comum;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    internal class ColaboradoresRepository
    {
        public bool Inserir(Colaboradores colaborador)
        {
            try
            {



                var sql = @"INSERT INTO [dbo].[Colaborador]
           ([Nome]
           ,[Telefone]
           ,[Nascimento]
           ,[cpf]
           ,[Genero]
           ,[Departamento]
           ,[Cargo]
           ,[CriadoEm]
           ,[CriadoPor]
           ,[AlteradoEm]
           ,[AlteradoPor]
           ,[Status]
           ,[EnderecoEstado]
           ,[EnderecoCidade]
           ,[EnderecoBairro]
           ,[EnderecoRua]
           ,[EnderecoNumero]
           ,[Nacionalidade]
           ,[EstadoCivil]
           ,[Rg])
     VALUES
           (Nome
           ,Telefone
           ,Nascimento
           ,cpf
           ,Genero
           ,Departamento
           ,Cargo
           ,CriadoEm
           ,CriadoPor
           ,AlteradoEm
           ,AlteradoPor
           ,Status
           ,EnderecoEstado
           ,EnderecoCidade
           ,EnderecoBairro
           ,EnderecoRua
           ,EnderecoNumero
           ,Nacionalidade
           ,EstadoCivil
            ,[Rg]
           ,[DataDeAdimissao])";

                using (var connection = new SqlConnection(SqlServer.StrConexaoHardCore()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nome",colaborador.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", colaborador.Telefone);
                    cmd.Parameters.AddWithValue("@Nascimento", colaborador.Nascimento);
                    cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
                    cmd.Parameters.AddWithValue("@Genero", colaborador.Genero);
                    cmd.Parameters.AddWithValue("@Departamento", colaborador.Departamento);
                    cmd.Parameters.AddWithValue("@Cargo", colaborador.Cargo);
                    cmd.Parameters.AddWithValue("@CriadoEm", colaborador.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", colaborador.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", colaborador.AlteradoEm);
                    cmd.Parameters.AddWithValue("@Status", colaborador.AlteradoPor);
                    cmd.Parameters.AddWithValue("@EnderecoEstado", colaborador.EnderecoEstado);
                    cmd.Parameters.AddWithValue("@EnderecoCidade", colaborador.EnderecoCidade);
                    cmd.Parameters.AddWithValue("@EnderecoBairro", colaborador.EnderecoBairro);
                    cmd.Parameters.AddWithValue("@EnderecoRua", colaborador.EnderecoRua);
                    cmd.Parameters.AddWithValue("@EnderecoNumero", colaborador.EnderecoNumero);
                    cmd.Parameters.AddWithValue("@Nacionalidade", colaborador.Nacionalidade);
                    cmd.Parameters.AddWithValue("@EstadoCivil", colaborador.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Rg", colaborador.Rg);

                    cmd.Parameters.AddWithValue("@DataDeAdimissao", colaborador.DataDeAdimissao);

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
