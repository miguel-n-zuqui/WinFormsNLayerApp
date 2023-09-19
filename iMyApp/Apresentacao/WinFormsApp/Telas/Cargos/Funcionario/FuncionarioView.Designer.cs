namespace WinFormsApp.Telas.Cargos.Funcionario
{
    partial class FuncionarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioView));
            btnSalvar = new Button();
            chkAtivo = new CheckBox();
            label5 = new Label();
            cbGenero = new ComboBox();
            pictureBox1 = new PictureBox();
            txtDepartamento = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            Telefone = new Label();
            txtCpf = new TextBox();
            dtpdataDeNascimento = new DateTimePicker();
            txtNomeCompleto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            cbCargo = new ComboBox();
            txtEmail = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(231, 298);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(130, 35);
            btnSalvar.TabIndex = 43;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(150, 273);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(120, 19);
            chkAtivo.TabIndex = 42;
            chkAtivo.Text = "Funcionario Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 205);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 41;
            label5.Text = "Genero";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(150, 229);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(121, 23);
            cbGenero.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(301, 162);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(206, 23);
            txtDepartamento.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 140);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 36;
            label4.Text = "Departamento";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(150, 140);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 35;
            Telefone.Text = "Telefone";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(407, 43);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 34;
            // 
            // dtpdataDeNascimento
            // 
            dtpdataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpdataDeNascimento.Location = new Point(150, 103);
            dtpdataDeNascimento.Name = "dtpdataDeNascimento";
            dtpdataDeNascimento.Size = new Size(114, 23);
            dtpdataDeNascimento.TabIndex = 33;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(150, 43);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(237, 23);
            txtNomeCompleto.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 80);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 31;
            label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 21);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 30;
            label2.Text = "Cpf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 21);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 29;
            label1.Text = "Nome completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 205);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 45;
            label6.Text = "Cargo";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(314, 229);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(121, 23);
            cbCargo.TabIndex = 44;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 80);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 46;
            label7.Text = "Email";
            // 
            // FuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbCargo);
            Controls.Add(btnSalvar);
            Controls.Add(chkAtivo);
            Controls.Add(label5);
            Controls.Add(cbGenero);
            Controls.Add(pictureBox1);
            Controls.Add(txtDepartamento);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(Telefone);
            Controls.Add(txtCpf);
            Controls.Add(dtpdataDeNascimento);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FuncionarioView";
            Text = "FuncionarioView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private CheckBox chkAtivo;
        private Label label5;
        private ComboBox cbGenero;
        private PictureBox pictureBox1;
        private TextBox txtDepartamento;
        private TextBox textBox2;
        private Label label4;
        private Label Telefone;
        private TextBox txtCpf;
        private DateTimePicker dtpdataDeNascimento;
        private TextBox txtNomeCompleto;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox cbCargo;
        private TextBox txtEmail;
        private Label label7;
    }
}