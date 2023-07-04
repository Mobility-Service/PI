using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmCadastrosColaboradores : Form
    {
        ClCadColaboradores ClCadColaboradores = new ClCadColaboradores();

        public string idSelecionado;
        public frmCadastrosColaboradores()
        {
            InitializeComponent();
            dgvColaboradoresCadastros.DataSource = ClCadColaboradores.BuscarTodosFuncionarios();
            ConfigurarGrade();
        }
        private void ConfigurarGrade()
        {

            dgvColaboradoresCadastros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dgvColaboradoresCadastros.DefaultCellStyle.Font = new Font("Arial", 9);

            dgvColaboradoresCadastros.Columns["codFunc"].HeaderText = "Código do Funcionario";
            dgvColaboradoresCadastros.Columns["codFunc"].ReadOnly = true;
            dgvColaboradoresCadastros.Columns["codFunc"].Width = 60;
            dgvColaboradoresCadastros.Columns["codFunc"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvColaboradoresCadastros.Columns["codFunc"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvColaboradoresCadastros.Columns["nome"].HeaderText = "Nome";
            dgvColaboradoresCadastros.Columns["nome"].Width = 300;
            dgvColaboradoresCadastros.Columns["nome"].ReadOnly = true;

            dgvColaboradoresCadastros.Columns["email"].HeaderText = "E-mail";
            dgvColaboradoresCadastros.Columns["email"].Width = 380;
            dgvColaboradoresCadastros.Columns["email"].ReadOnly = true;
            dgvColaboradoresCadastros.Columns["codFunc"].Frozen = true;



        }

        private void dgvColaboradoresCadastros_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgvColaboradoresCadastros.Rows[dgvColaboradoresCadastros.SelectedRows[0].Index].Cells[1].Value.ToString();



                frmFuncionarios abrir = new frmFuncionarios(idSelecionado);

                abrir.Show();
                this.Hide();


            }
        }
    }
}
