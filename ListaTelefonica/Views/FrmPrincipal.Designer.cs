namespace ListaTelefonica.Views
{
    partial class FrmPrincipal
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 38);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(554, 260);
            this.dgvLista.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(461, 9);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(105, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "&Buscar Contato";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 304);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(126, 23);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "&Adicionar Contato";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(144, 304);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(130, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "&Editar Contato";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(461, 304);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox textBox1;
    }
}