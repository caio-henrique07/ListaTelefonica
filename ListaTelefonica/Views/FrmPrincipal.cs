using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListaTelefonica.Models;
using ListaTelefonica.Presenters;

namespace ListaTelefonica.Views
{
    public partial class FrmPrincipal : Form
    {
        private ContatoPresenter presenter;
        Contato edicao;
        public FrmPrincipal()
        {
            InitializeComponent();
            presenter = new ContatoPresenter();
            Atualizar();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FrmNovoContato frm = new FrmNovoContato(presenter);
            frm.ShowDialog();
            Atualizar();

        }

        private void Atualizar()
        {
            dgvLista.DataSource = presenter.BuscarContato(txtBusca.Text.Trim());
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvLista.SelectedCells[0].RowIndex;
            int id = (int)dgvLista.Rows[linha].Cells[0].Value;

            edicao = presenter.SelecionarContato(id);

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void Limpar()
        {
            edicao = null;
            btEditar.Enabled = false;
            btRemover.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditarContato frm = new FrmEditarContato(presenter, edicao);
            frm.ShowDialog();
            Atualizar();
            Limpar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja remover o contato selecionado?",
                "Atenção", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                presenter.RemoverContato(edicao);
                Atualizar();
                Limpar();
            }
        }
    }
}
