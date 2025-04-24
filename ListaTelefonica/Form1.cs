using System;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        string[][] lista;
        readonly int MAX = 100;

        public Form1()
        {
            InitializeComponent();
            lista = new string[MAX][];
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        int Length(string[][] e)
        {
            int itens = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] != null)
                {
                    itens++;
                }
            }
            return itens;
        }

        int Length(string[] e)
        {
            int itens = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] != null)
                {
                    itens++;
                }
            }
            return itens;
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
            for (int i = 0; i < Length(lista); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLista);
                for (int j = 0; j < Length(lista[i]); j++)
                {
                    row.Cells[j].Value = lista[i][j];
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

            if (Length(lista) >= MAX)
            {
                MessageBox.Show("A lista está cheia!", "Máximo de itens atingido");
                return;
            }

            int id = 1;
            if(Length(lista) > 0)
            {
                id = int.Parse(lista[Length(lista) - 1][0]) + 1;
            }
            lista[Length(lista)] = new string[] {id.ToString(), txtNome.Text, txtTel.Text };

            Atualizar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um contato para remover.");
                return;
            }

            int linha = dgvLista.SelectedCells[0].RowIndex;

            if (linha < 0 || linha >= lista.Length || lista[linha] == null)
            {
                MessageBox.Show("Selecione um item válido");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja de fato remover o contato de "
                + lista[linha][1] + "?",
                "REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                for (int i = linha; i < Length(lista) - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }

                lista[Length(lista) - 1] = null;
            }

            Atualizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}