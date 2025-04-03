namespace ListaTelefonica
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Lavender;
            this.lblNome.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(660, 47);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(92, 28);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Lavender;
            this.lblTel.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(660, 142);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(145, 28);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "TELEFONE";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Lavender;
            this.txtNome.Location = new System.Drawing.Point(793, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Lavender;
            this.txtTel.Location = new System.Drawing.Point(856, 145);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Mask = "(00) 00000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(105, 22);
            this.txtTel.TabIndex = 3;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Lavender;
            this.btAdicionar.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(745, 210);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(217, 49);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.Text = "ADICIONAR";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone});
            this.dgvLista.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvLista.Location = new System.Drawing.Point(33, 47);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(588, 479);
            this.dgvLista.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 125;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ListaTelefonica.Properties.Resources.notlikeus;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(877, 353);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 172);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ListaTelefonica.Properties.Resources.maiordomundo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(665, 353);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 172);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.Lavender;
            this.btRemover.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(745, 282);
            this.btRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(217, 49);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "REMOVER";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListaTelefonica.Properties.Resources.bakckground;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button btRemover;
    }
}

