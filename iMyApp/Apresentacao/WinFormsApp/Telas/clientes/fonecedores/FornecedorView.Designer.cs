namespace WinFormsApp.Telas.clientes.fonecedores
{
    partial class FornecedorView
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
            gridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
            SuspendLayout();
            // 
            // gridview
            // 
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.Location = new Point(69, 107);
            gridview.Name = "gridview";
            gridview.RowTemplate.Height = 25;
            gridview.Size = new Size(648, 300);
            gridview.TabIndex = 1;
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridview);
            Name = "FornecedorView";
            Text = "FornecedorView";
            Load += FornecedorView_Load;
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridview;
    }
}