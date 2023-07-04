using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmCadastraPessoa : Form
    {
        public frmCadastraPessoa()
        {
            InitializeComponent();
            carregarCabecalho();
        }

        DataTable dt = new DataTable();

        public void carregarCabecalho()
        {
            dt.Columns.Add("Código", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));

            dgvDadosPessoais.DataSource = dt;
        }

        public void limparCampos()
        {
            txtcod.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Text ="";
            mskTelefone.Text = "";

           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtcod.Text, txtNome.Text, txtEmail.Text, mskCpf.Text, mskTelefone.Text);
            dgvDadosPessoais.DataSource = dt;
            limparCampos();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDadosPessoais.CurrentRow != null)
            {
                int linha = dgvDadosPessoais.CurrentCell.RowIndex;
                dgvDadosPessoais.Rows.RemoveAt(linha);
            }
            else
            {
                MessageBox.Show("Dados excluídos");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dgvDadosPessoais.DataSource = dt;
        }

        private void dgvDadosPessoais_SelectionChanged(object sender, EventArgs e)
        {
            txtcod.Text = dgvDadosPessoais.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvDadosPessoais.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvDadosPessoais.CurrentRow.Cells[2].Value.ToString();
            mskCpf.Text = dgvDadosPessoais.CurrentRow.Cells[3].Value.ToString();
            mskTelefone.Text = dgvDadosPessoais.CurrentRow.Cells[4].Value.ToString();
        }

		private void dgvDadosPessoais_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}



}
