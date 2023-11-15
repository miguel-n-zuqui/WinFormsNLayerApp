namespace WinFormsApp.Telas.clientes.Usuario
{
    partial class frmUsuario
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
            label1 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSubject = new TextBox();
            label4 = new Label();
            txtMenssage = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 22);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "DE";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(154, 55);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(261, 23);
            txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(154, 155);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(261, 23);
            txtTo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 122);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "PARA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 209);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "ASSUNTO";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(154, 242);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(363, 23);
            txtSubject.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 285);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "ASSUNTO";
            // 
            // txtMenssage
            // 
            txtMenssage.Location = new Point(154, 321);
            txtMenssage.Multiline = true;
            txtMenssage.Name = "txtMenssage";
            txtMenssage.Size = new Size(363, 81);
            txtMenssage.TabIndex = 8;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(154, 441);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 509);
            Controls.Add(btnEnviar);
            Controls.Add(txtMenssage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Label label2;
        private Label label3;
        private TextBox txtSubject;
        private Label label4;
        private TextBox txtMenssage;
        private Button btnEnviar;
    }
}