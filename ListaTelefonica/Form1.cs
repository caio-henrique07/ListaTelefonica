using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        string[,] lista;
        readonly int MAX = 100;
        int itens = 0;

        public Form1()
        {
            InitializeComponent();
            lista = new string[MAX, 2];
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (txtNome.Focused && !String.IsNullOrWhiteSpace(txtNome.Text))
                {
                    txtTel.Focus();
                    return;
                }

                if (txtTel.Focused && txtTel.MaskFull)
                {
                    btAdicionar_Click(this, new EventArgs());
                }
            }
        }

        void Atualizar()
        {
            dgvLista.Rows.Clear();
            for (int i = 0; i < itens; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLista);
                for (int j = 0; j < 2; j++)
                {
                    row.Cells[j].Value = lista[i, j];
                }
                dgvLista.Rows.Add(row);
            }
            txtNome.Clear();
            txtTel.Clear();
            txtNome.Focus();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text) ||
                !(txtTel.MaskFull))
            {
                MessageBox.Show("Insira um nome e telefone válidos.");
                return;
            }

            if (itens >= MAX)
            {
                MessageBox.Show("A lista está cheia!", "Máximo de itens atingido");
                return;
            }

            lista[itens, 0] = txtNome.Text;
            lista[itens, 1] = txtTel.Text;
            itens++;

            Atualizar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um contato para remover.");
                return;
            }

            int indice = dgvLista.SelectedCells[0].RowIndex;

            if (indice < 0 || indice >= itens)
            {
                MessageBox.Show("Selecione um item válido");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja de fato remover o item "
                + lista[indice, 0] + "?",
                "REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            for (int i = indice; i < itens - 1; i++)
            {
                lista[i, 0] = lista[i + 1, 0];
                lista[i, 1] = lista[i + 1, 1];
            }

            itens--;

            Atualizar();
        }
    }
}