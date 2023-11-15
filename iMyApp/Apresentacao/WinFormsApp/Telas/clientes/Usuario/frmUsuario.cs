using Negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Telas.clientes.Usuario
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var emailService = new EmailService(txtFrom.Text, txtTo.Text, txtSubject.Text,txtMenssage.Text);
            emailService.EmailRecuperar("miguelnatalezuqui@gmail.com");//miguel.zuqui@es.estudante.senai.br
        }
    }
}
