using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//connect class import
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmTestaBanco : Form
    {
        public frmTestaBanco()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "server=localhost;port=3306;database=dbmobiliteservice;uid=admin;pwd=123456";
            //conn.Open();
            //MessageBox.Show("Banco de Dados Conectado.");
            Connect.obterConexao();
            MessageBox.Show("Banco de Dados Conectado.");

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "server=localhost;port=3306;database=dbmobiliteservice;uid=admin;pwd=123456";
            //conn.Close();
            //MessageBox.Show("Banco de Dados Desconectado. ");
            Connect.fecharConexao();
            MessageBox.Show("Banco de Dados Desconectado. ");
        }
    }
}
