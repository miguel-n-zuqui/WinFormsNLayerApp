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
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Colaboradores(string nome,
                            string telefone,
                            DateTime nascimento,
                            string cpf,
                            string genero,
                            string departamento,
                            string cargo,
                            DateTime criadoEm,
                            string criadoPor,
                            DateTime alteradoEm,
                            string alteradoPor,
                            bool status,
                            string enderecoEstado,
                            string enderecoCidade,
                            string enderecoBairro,
                            string enderecoRua,
                            string enderecoNumero,
                            string nacionalidade,
                            string estadoCivil,
                            DateTime dataAdmissao, string rg) 
        {
            nome = Nome;
            telefone = Telefone;
            genero = Genero;
            departamento = Departamento;
            cargo = Cargo;
            cpf = Cpf;
            rg = Rg;
            status = Status;
            nascimento = Nascimento;
            rg = Rg;
            criadoEm = CriadoEm;
            criadoPor = CriadoPor;
            alteradoEm = AlteradoEm;
            alteradoPor = AlteradoPor;
            enderecoEstado = EnderecoEstado;
            enderecoCidade = EnderecoCidade;
            enderecoBairro = EnderecoBairro;
            enderecoRua = EnderecoRua;
            enderecoNumero = EnderecoNumero;
            estadoCivil = EstadoCivil;
            nacionalidade = Nacionalidade;
            dataAdmissao = DataAdmissao;
        }
    }
}
