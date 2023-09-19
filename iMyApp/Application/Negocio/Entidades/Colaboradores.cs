using Negocio.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Colaboradores: Pessoa
    {

        public Colaboradores(string nome , string cpf, DateTime nascimento,string email , bool status, DateTime criadoEm , string criadoPor) 
        {
            nome = Nome ;
            cpf=Cpf  ;
            nascimento =Nascimento  ;
            email = Email ;
            status = Status;
            criadoEm = CriadoEm;
            criadoPor = CriadoPor ;
        }
    }
}
