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
    public partial class frmControleDeAcesso : Form
    {
     

        public frmControleDeAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opcoes = Opcoes.Criar(mspUsuarios);

            dataGridView1.DataSource = opcoes.ToList();

            ConfigurarGrade();

          //  Opcoes.SalvarMenu(opcoes);

          //  MessageBox.Show("Gerado");

            
        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 300;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["email"].Width = 380;
            dataGridView1.Columns["email"].ReadOnly = true;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrosClientes abrir = new frmCadastrosClientes();

            abrir.Show();
            this.Hide();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrosColaboradores abrir = new frmCadastrosColaboradores();
            abrir.Show();
            this.Hide();
        }
    }
}
