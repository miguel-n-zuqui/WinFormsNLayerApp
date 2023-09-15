namespace WinFormsApp.Telas.Cargos
{
    partial class CargoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grupoBoxCargo = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCargo = new TextBox();
            btnNovoCargo = new Button();
            gvCargos = new DataGridView();
            label1 = new Label();
            btnRecarregar = new Button();
            grupoBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // grupoBoxCargo
            // 
            grupoBoxCargo.Controls.Add(btnSalvar);
            grupoBoxCargo.Controls.Add(chkStatus);
            grupoBoxCargo.Controls.Add(txtCargo);
            grupoBoxCargo.FlatStyle = FlatStyle.Popup;
            grupoBoxCargo.Location = new Point(12, 34);
            grupoBoxCargo.Name = "grupoBoxCargo";
            grupoBoxCargo.Size = new Size(776, 69);
            grupoBoxCargo.TabIndex = 0;
            grupoBoxCargo.TabStop = false;
            grupoBoxCargo.Text = "Novo Cargo";
            grupoBoxCargo.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(613, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 32);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += tbnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatus.Location = new Point(402, 21);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(128, 29);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Cargo ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(8, 23);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(388, 23);
            txtCargo.TabIndex = 0;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.BackColor = Color.White;
            btnNovoCargo.FlatStyle = FlatStyle.Flat;
            btnNovoCargo.Location = new Point(40, 5);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(111, 23);
            btnNovoCargo.TabIndex = 3;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = false;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToAddRows = false;
            gvCargos.BackgroundColor = SystemColors.GradientActiveCaption;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.GridColor = SystemColors.GradientActiveCaption;
            gvCargos.Location = new Point(12, 153);
            gvCargos.Name = "gvCargos";
            gvCargos.ReadOnly = true;
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(776, 272);
            gvCargos.TabIndex = 4;
            gvCargos.CellMouseClick += gvCargos_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 5;
            label1.Text = "Todos os cargos";
            label1.Click += label1_Click;
            // 
            // btnRecarregar
            // 
            btnRecarregar.BackColor = Color.White;
            btnRecarregar.FlatStyle = FlatStyle.Flat;
            btnRecarregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarregar.Location = new Point(625, 109);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(115, 41);
            btnRecarregar.TabIndex = 3;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = false;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(gvCargos);
            Controls.Add(btnNovoCargo);
            Controls.Add(grupoBoxCargo);
            Name = "CargoView";
            Text = "CargoView";
            Load += CargoView_Load;
            grupoBoxCargo.ResumeLayout(false);
            grupoBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox grupoBoxCargo;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtCargo;
        private Button btnNovoCargo;
        private DataGridView gvCargos;
        private Label label1;
        private Button btnRecarregar;
    }
}