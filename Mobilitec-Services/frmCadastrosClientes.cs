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
    public partial class frmCadastrosClientes : Form
    {
        ClCadClientes ClCadClientes = new ClCadClientes();

         public string idSelecionado;

        
        public frmCadastrosClientes()
        {
            InitializeComponent();
            dgvClientesCadastros.DataSource = ClCadClientes.BuscarTodos();
            ConfigurarGrade();
           

        }

        private void ConfigurarGrade()
        {
            
            dgvClientesCadastros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dgvClientesCadastros.DefaultCellStyle.Font = new Font("Arial", 9);

            dgvClientesCadastros.Columns["codCli"].HeaderText = "Código do cliente";
            dgvClientesCadastros.Columns["codCli"].ReadOnly = true;
            dgvClientesCadastros.Columns["codCli"].Width = 60;
            dgvClientesCadastros.Columns["codCli"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvClientesCadastros.Columns["codCli"].DefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;

            dgvClientesCadastros.Columns["nome"].HeaderText = "Nome";
            dgvClientesCadastros.Columns["nome"].Width = 300;
            dgvClientesCadastros.Columns["nome"].ReadOnly = true;

            dgvClientesCadastros.Columns["email"].HeaderText = "E-mail";
            dgvClientesCadastros.Columns["email"].Width = 380;
            dgvClientesCadastros.Columns["email"].ReadOnly = true;
            dgvClientesCadastros.Columns["codCli"].Frozen = true;



        }



        private void dgvClientesCadastros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgvClientesCadastros.Rows[dgvClientesCadastros.SelectedRows[0].Index].Cells[1].Value.ToString();
                


                frmClientes abrir = new frmClientes(idSelecionado);

                abrir.Show();
                this.Hide();


            }
        }

        private void dgvClientesCadastros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
