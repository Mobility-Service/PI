
namespace Mobilitec_Services
{
    partial class frmCadastraPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraPessoa));
			this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtcod = new System.Windows.Forms.TextBox();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.mskCpf = new System.Windows.Forms.MaskedTextBox();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCod = new System.Windows.Forms.Label();
			this.dgvDadosPessoais = new System.Windows.Forms.DataGridView();
			this.gpbBtn = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gpbDadosPessoais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDadosPessoais)).BeginInit();
			this.gpbBtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbDadosPessoais
			// 
			this.gpbDadosPessoais.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.gpbDadosPessoais.Controls.Add(this.txtEmail);
			this.gpbDadosPessoais.Controls.Add(this.txtNome);
			this.gpbDadosPessoais.Controls.Add(this.txtcod);
			this.gpbDadosPessoais.Controls.Add(this.mskTelefone);
			this.gpbDadosPessoais.Controls.Add(this.mskCpf);
			this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
			this.gpbDadosPessoais.Controls.Add(this.lblCpf);
			this.gpbDadosPessoais.Controls.Add(this.lblNome);
			this.gpbDadosPessoais.Controls.Add(this.lblEmail);
			this.gpbDadosPessoais.Controls.Add(this.lblCod);
			this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDadosPessoais.Location = new System.Drawing.Point(25, 27);
			this.gpbDadosPessoais.Name = "gpbDadosPessoais";
			this.gpbDadosPessoais.Size = new System.Drawing.Size(737, 200);
			this.gpbDadosPessoais.TabIndex = 0;
			this.gpbDadosPessoais.TabStop = false;
			this.gpbDadosPessoais.Text = "Dados Pessoais";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(62, 149);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(262, 26);
			this.txtEmail.TabIndex = 9;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(180, 63);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 26);
			this.txtNome.TabIndex = 8;
			// 
			// txtcod
			// 
			this.txtcod.Location = new System.Drawing.Point(62, 63);
			this.txtcod.Name = "txtcod";
			this.txtcod.Size = new System.Drawing.Size(72, 26);
			this.txtcod.TabIndex = 7;
			// 
			// mskTelefone
			// 
			this.mskTelefone.Location = new System.Drawing.Point(481, 149);
			this.mskTelefone.Mask = "(00) 00000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(131, 26);
			this.mskTelefone.TabIndex = 6;
			// 
			// mskCpf
			// 
			this.mskCpf.Location = new System.Drawing.Point(342, 149);
			this.mskCpf.Mask = "000,000,000-00";
			this.mskCpf.Name = "mskCpf";
			this.mskCpf.Size = new System.Drawing.Size(123, 26);
			this.mskCpf.TabIndex = 5;
			// 
			// lblTelefone
			// 
			this.lblTelefone.AutoSize = true;
			this.lblTelefone.Location = new System.Drawing.Point(477, 113);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(71, 20);
			this.lblTelefone.TabIndex = 4;
			this.lblTelefone.Text = "Telefone";
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Location = new System.Drawing.Point(338, 113);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(40, 20);
			this.lblCpf.TabIndex = 3;
			this.lblCpf.Text = "CPF";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(176, 40);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(51, 20);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(69, 113);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 20);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "E-mail";
			// 
			// lblCod
			// 
			this.lblCod.AutoSize = true;
			this.lblCod.Location = new System.Drawing.Point(69, 40);
			this.lblCod.Name = "lblCod";
			this.lblCod.Size = new System.Drawing.Size(59, 20);
			this.lblCod.TabIndex = 0;
			this.lblCod.Text = "Código";
			// 
			// dgvDadosPessoais
			// 
			this.dgvDadosPessoais.AllowUserToAddRows = false;
			this.dgvDadosPessoais.AllowUserToResizeColumns = false;
			this.dgvDadosPessoais.AllowUserToResizeRows = false;
			this.dgvDadosPessoais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDadosPessoais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.dgvDadosPessoais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDadosPessoais.Location = new System.Drawing.Point(25, 233);
			this.dgvDadosPessoais.Name = "dgvDadosPessoais";
			this.dgvDadosPessoais.Size = new System.Drawing.Size(737, 233);
			this.dgvDadosPessoais.TabIndex = 1;
			this.dgvDadosPessoais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosPessoais_CellContentClick);
			this.dgvDadosPessoais.SelectionChanged += new System.EventHandler(this.dgvDadosPessoais_SelectionChanged);
			// 
			// gpbBtn
			// 
			this.gpbBtn.Controls.Add(this.btnClear);
			this.gpbBtn.Controls.Add(this.btnDel);
			this.gpbBtn.Controls.Add(this.btnAdd);
			this.gpbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbBtn.Location = new System.Drawing.Point(25, 472);
			this.gpbBtn.Name = "gpbBtn";
			this.gpbBtn.Size = new System.Drawing.Size(737, 76);
			this.gpbBtn.TabIndex = 2;
			this.gpbBtn.TabStop = false;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(582, 25);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 30);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Limpar";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(316, 25);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(100, 30);
			this.btnDel.TabIndex = 1;
			this.btnDel.Text = "Excluir";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(50, 25);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Adicionar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmCadastraPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(800, 560);
			this.Controls.Add(this.gpbBtn);
			this.Controls.Add(this.dgvDadosPessoais);
			this.Controls.Add(this.gpbDadosPessoais);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCadastraPessoa";
			this.Text = "frmCadastraPessoa";
			this.gpbDadosPessoais.ResumeLayout(false);
			this.gpbDadosPessoais.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDadosPessoais)).EndInit();
			this.gpbBtn.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridView dgvDadosPessoais;
        private System.Windows.Forms.GroupBox gpbBtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
    }
}