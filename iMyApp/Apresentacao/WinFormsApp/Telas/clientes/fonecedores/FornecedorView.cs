using Negocio.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Telas.clientes.fonecedores
{
    public partial class FornecedorView : Form
    {
        private IFornecedorRepository _fornecedorRepository;
        public FornecedorView()
        {
            InitializeComponent();
            _fornecedorRepository = new FornecedorRepository();
        }
        public FornecedorView(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        private void FornecedorView_Load(object sender, EventArgs e)
        {
            var listaFornedores = _fornecedorRepository.ObterTodos(); ;
            gridview.DataSource = listaFornedores;
        }
    }
}
