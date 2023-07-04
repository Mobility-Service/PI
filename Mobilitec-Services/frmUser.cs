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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace Mobilitec_Services
{
    public partial class frmUser : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmUser_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public frmUser()
        {
            InitializeComponent();
            desabilitarCampos();

        }
        public frmUser(string nomeUsu)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nomeUsu;
            habilitarCamposPesqu();
            pesquisaPorNomeCliente(txtNome.Text);

          
        }
        public void pesquisaPorNomeCliente(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nomeUsu like '%" + nome + "%'; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Connect.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);
           

            Connect.fecharConexao();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarInfos(Convert.ToInt32(txtCodigo.Text));
            desabilitarCampos();
            limparCampos();
        }
        public void alterarInfos(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nomeUsu = @nome, senhaUsu = @senha, where codUsu =" + codUsu + ";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 100).Value = txtSenha.Text;
            


            comm.Connection = Connect.obterConexao();
            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Resgistro alterado com sucesso.");

            Connect.fecharConexao();

        }

        public int excluirCliente(int codUsu)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "delete from tbUsuarios where codUsu =   @codUsu ;";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;

            conn.Connection = Connect.obterConexao();

            int resp = conn.ExecuteNonQuery();

            if (resp == 1)
            {
                return resp;
            }
            else
            {
                return resp;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja excluir?",
                "Mensagem do Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (resposta == DialogResult.Yes)
            {
                int resp = excluirCliente(Convert.ToInt32(txtCodigo.Text));
                limparCampos();
                MessageBox.Show("Excluido com Sucesso",
                "Mensagem do Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
            else
            {

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPsqUser abrir = new frmPsqUser();
            abrir.ShowDialog();
            this.Hide();
        }

 

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
        //criando método para desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //criando método para habilitarCamposNovo
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
        }
        public void habilitarCamposPesqu()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
          

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }

        //criando o método limparCampos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtNome.Focus();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        public void cdtUser()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nomeUsu,senhaUsu) values(@nomeUsu,@senhaUSu)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeUsu", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@senhaUsu", MySqlDbType.VarChar, 100).Value = txtSenha.Text;
            

            comm.Connection = Connect.obterConexao();
            int res = comm.ExecuteNonQuery();



            Connect.fecharConexao();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campo vazio", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }



            MessageBox.Show("Cadastrado com sucesso.", "Mensagem do Sistema",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            cdtUser();
            limparCampos();
            desabilitarCampos();
            btnNovo.Enabled = true;

        }
    }
}
