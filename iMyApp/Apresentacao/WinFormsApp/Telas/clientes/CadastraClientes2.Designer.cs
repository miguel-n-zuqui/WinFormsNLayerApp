namespace WinFormsApp.Telas.Clientes
{
    partial class ClientesCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesCadastrar));
            chkEhResponsavel = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            Telefone = new Label();
            txtCpf = new TextBox();
            dtpdataDeNascimento = new DateTimePicker();
            txtNomeCompleto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkEhResponsavel
            // 
            chkEhResponsavel.AutoSize = true;
            chkEhResponsavel.Location = new Point(145, 292);
            chkEhResponsavel.Name = "chkEhResponsavel";
            chkEhResponsavel.Size = new Size(183, 19);
            chkEhResponsavel.TabIndex = 27;
            chkEhResponsavel.Text = "Cliente é o responsável legal? ";
            chkEhResponsavel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 224);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 26;
            label5.Text = "Bolsa de Estudos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 159);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 21;
            label4.Text = "Email";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(145, 159);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 20;
            Telefone.Text = "Telefone";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(402, 62);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 19;
            // 
            // dtpdataDeNascimento
            // 
            dtpdataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpdataDeNascimento.Location = new Point(145, 122);
            dtpdataDeNascimento.Name = "dtpdataDeNascimento";
            dtpdataDeNascimento.Size = new Size(114, 23);
            dtpdataDeNascimento.TabIndex = 18;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(145, 62);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(237, 23);
            txtNomeCompleto.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 99);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 16;
            label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 40);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 15;
            label2.Text = "Cpf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome completo";
            // 
            // ClientesCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkEhResponsavel);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(Telefone);
            Controls.Add(txtCpf);
            Controls.Add(dtpdataDeNascimento);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientesCadastrar";
            Text = "CadastraClientes2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEhResponsavel;
        private Label label5;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label Telefone;
        private TextBox txtCpf;
        private DateTimePicker dtpdataDeNascimento;
        private TextBox txtNomeCompleto;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}