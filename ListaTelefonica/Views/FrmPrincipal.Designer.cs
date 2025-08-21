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
            this.components = new System.ComponentModel.Container();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.contatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoGenerateColumns = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvLista.DataSource = this.contatoBindingSource;
            this.dgvLista.Location = new System.Drawing.Point(12, 38);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(554, 260);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(ListaTelefonica.Models.Contato);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(461, 9);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(105, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "&Buscar Contato";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
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
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(144, 304);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(130, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "&Editar Contato";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Enabled = false;
            this.btRemover.Location = new System.Drawing.Point(461, 304);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(105, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "&Excluir";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 12);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(443, 20);
            this.txtBusca.TabIndex = 5;
            // 
            // contatoBindingSource1
            // 
            this.contatoBindingSource1.DataSource = typeof(ListaTelefonica.Models.Contato);
            // 
            // contatoBindingSource2
            // 
            this.contatoBindingSource2.DataSource = typeof(ListaTelefonica.Models.Contato);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 334);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contatoBindingSource1;
        private System.Windows.Forms.BindingSource contatoBindingSource2;
    }
}