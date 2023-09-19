using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Telas.Cargos.Funcionario
{
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var criadoEm = DateTime.Now;
            var novoFuncionario = new Colaboradores(txtNomeCompleto.Text, txtCpf.Text,
            DateTime.Parse(dtpdataDeNascimento.Text), txtEmail.Text, chkAtivo.Checked, criadoEm, txtNomeCompleto.Text);
        }
    }
}
