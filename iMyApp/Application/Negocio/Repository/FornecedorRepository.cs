using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public List<Fornecedor> ObterTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            for (int i = 1; i <= 50; i++)
            {
                fornecedores.Add(new Fornecedor
                {
                    Id = i,
                    Nome = "Fornecedor " + i,
                    Telefone = "(123) 456-7890",
                    Uf = "UF" + i,
                    Cidade = "Cidade" + i
                });
            }

            return fornecedores;
        }
    }
}
