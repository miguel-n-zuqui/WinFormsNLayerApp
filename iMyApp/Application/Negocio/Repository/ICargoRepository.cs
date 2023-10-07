using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repository
{
    public interface ICargoRepository
    {
        bool Incluir(Cargo cargo);  
        bool Atualizar(Cargo cargo);    
        bool Deletar(Cargo cargo);
        List<Cargo> ObterTodos();
        List<Cargo> ObterPorStatus(int cargoPorStatus);
        Cargo ObterPorId(int id);
        object Deletar(int v);
    }
}
