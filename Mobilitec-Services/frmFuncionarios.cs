using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Mobilitec_Services
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
            cbbSexo.Items.Add("Feminino");
            cbbSexo.Items.Add("Masculino");

        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            habilitarCamposPesqu();
            pesquisaPorNomeFuncionario(txtNome.Text);
            cbbSexo.Items.Add("Feminino");
            cbbSexo.Items.Add("Masculino");
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
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            cbbSexo.Enabled = false;
            mkbCEP.Enabled = false;
            mkbCPF.Enabled = false;
            mkbTelefone.Enabled = false;
            txtUsuario.Enabled = false;
            btnAdicionarImg.Enabled = false;
            btnApagar.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnTestarCEP.Enabled = false;
        }

        //criando método para habilitarCamposNovo
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;
            txtUsuario.Enabled = true;
            btnAdicionarImg.Enabled = true;
            btnApagar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnTestarCEP.Enabled = true;

        }
        public void habilitarCamposPesqu()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;

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
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            cbbSexo.Text = "";
            mkbCEP.Clear();
            mkbCPF.Clear();
            mkbTelefone.Clear();
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

        public void cdtFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)values(@nome,@email,@cpf,@telefone,@sexo,@endereco,@numero,@cep,@bairro,@cidade,@estado)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTelefone.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;

            comm.Connection = Connect.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastro concluido com sucesso!!!");

            Connect.fecharConexao();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, Insira um endereço de e-mail válido.", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("")
            || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")
            || mkbCPF.Text.Equals("   .   .   -") || mkbTelefone.Text.Equals("(  )      -")
            || mkbCEP.Text.Equals("     -") || cbbEstado.Text.Equals("") || cbbSexo.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campo vazio", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }

            MessageBox.Show("Cadastrado com sucesso.", "Mensagem do Sistema",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            cdtFunc();
            limparCampos();
            desabilitarCampos();
            btnNovo.Enabled = true;


        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(email, pattern);
        }






        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrir a janela de pesquisar
            frmPesquisaFunc abrir = new frmPesquisaFunc();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarInfos(Convert.ToInt32(txtCodigo.Text));
            desabilitarCampos();
            limparCampos();
        }
        public void alterarInfos(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome = @nome, email = @email, cpf = @cpf, telefone = @telefone, sexo = @sexo, endereco = @endereco, numero = @numero, cep = @cep, bairro = @bairro, cidade = @cidade, estado = @estado where codFunc =" + codFunc + ";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTelefone.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;


            comm.Connection = Connect.obterConexao();
            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Resgistro alterado com sucesso.");

            Connect.fecharConexao();

        }

        public int excluirFunc(int codFunc)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "delete from tbFuncionarios where codFunc =   @codfUnc ;";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;

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
            Connect.fecharConexao();
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
                int resp = excluirFunc(Convert.ToInt32(txtCodigo.Text));
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

        public void buscaCep(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);
            txtEndereco.Text = endereco.end;
            txtBairro.Text = endereco.bairro;
            cbbEstado.Text = endereco.uf;
            txtCidade.Text = endereco.cidade;
        }



        public void pesquisaPorNomeFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome like '%" + nome + "%'; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Connect.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mkbCPF.Text = DR.GetString(3);
            mkbTelefone.Text = DR.GetString(4);
            cbbSexo.Text = DR.GetString(5);
            txtEndereco.Text = DR.GetString(6);
            txtNumero.Text = DR.GetString(7);
            mkbCEP.Text = DR.GetString(8);
            txtBairro.Text = DR.GetString(9);
            txtCidade.Text = DR.GetString(10);
            cbbEstado.Text = DR.GetString(11);

            Connect.fecharConexao();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImg = new OpenFileDialog();
            BuscarImg.InitialDirectory = ("d\\imagens\\");
            BuscarImg.FileName = "Imagem";
            BuscarImg.Title = "Procurar Imagem";
            BuscarImg.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarImg.ShowDialog();
            pcbFoto.ImageLocation = (BuscarImg.FileName);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnTestarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                buscaCep(mkbCEP.Text);
                txtNumero.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Número de CEP inválido", "Mensagem do Sistema",
               MessageBoxButtons.OK, MessageBoxIcon.Error
               );

                mkbCEP.Focus();
            }
        }
    }
}


