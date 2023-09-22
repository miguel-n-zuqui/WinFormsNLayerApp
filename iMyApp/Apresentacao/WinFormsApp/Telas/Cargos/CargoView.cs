using Database.Repositorios;
using Negocio.Entidades;
using Negocio.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WinFormsApp.Telas.Cargos
{
    public partial class CargoView : Form
    {
        int id = -1;
        public CargoView()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            grupoBoxCargo.Visible = !grupoBoxCargo.Visible;
            btnSalvar.Text = "Atualizar";
           
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {

            Button? botao = sender as Button;

            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            var novoCargo = new Cargo(nome, status);


            var erros = Validacoes.getValidationErros(novoCargo);
            foreach ( var erro in erros ) { MessageBox.Show(erro.ErrorMessage); }



            var cargo = new CargoRepository();
            switch (botao.Text)
            {
                case "Atualizar":
                    {
                        cargo.Inserir(novoCargo);

                        var resultado = cargo.Inserir(novoCargo);

                        if (resultado)
                        {
                            MessageBox.Show("Cargo cadastrado com sucesso!!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel gravar o cargo!!");
                        }
                        //cadastar
                        break;
                    }
                case "Salvar":
                    {
                        cargo.Atualizar(novoCargo, id);
                        MessageBox.Show("Cargo alterado com sucesso!!");
                        //cadastar
                        break;
                    }
                default:
                    break;
            }

        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            carregarCargos();
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregarCargos();
        }

        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cargoRepository = new CargoRepository();
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];

            if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                    MessageBox.Show("Deletado com sucesso");
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    grupoBoxCargo.Show();
                    btnSalvar.Text = "Atualizar";
                    txtCargo.Text = row.Cells[2].Value.ToString();
                    chkStatus.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
                    id = Convert.ToInt32(row.Cells[1].Value);
                }
            }

        }
        private void carregarCargos()
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var cargo = new CargoRepository();

            var reader = cargo.Complemento(nome);

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();


            foreach (var i in reader)
            {
                autoCompleteStringCollection.Add(i);
            }

            txtCargo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCargo.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
    }
}
