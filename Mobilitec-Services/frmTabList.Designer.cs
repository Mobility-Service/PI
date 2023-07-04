
namespace Mobilitec_Services
{
    partial class frmTabList
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPropaganda = new System.Windows.Forms.Label();
            this.ckbAutorizo = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcCadastro.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tbpCadastro);
            this.tbcCadastro.Controls.Add(this.tabPage2);
            this.tbcCadastro.Location = new System.Drawing.Point(12, 12);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(649, 371);
            this.tbcCadastro.TabIndex = 1;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.txtCodigo);
            this.tbpCadastro.Controls.Add(this.btnLimpar);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.ckbAutorizo);
            this.tbpCadastro.Controls.Add(this.lblPropaganda);
            this.tbpCadastro.Controls.Add(this.lblNome);
            this.tbpCadastro.Controls.Add(this.lblcodigo);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(641, 345);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCadastro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(40, 37);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(40, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblPropaganda
            // 
            this.lblPropaganda.AutoSize = true;
            this.lblPropaganda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropaganda.Location = new System.Drawing.Point(40, 154);
            this.lblPropaganda.Name = "lblPropaganda";
            this.lblPropaganda.Size = new System.Drawing.Size(251, 20);
            this.lblPropaganda.TabIndex = 2;
            this.lblPropaganda.Text = "Autorizo o envio de propagandas?";
            // 
            // ckbAutorizo
            // 
            this.ckbAutorizo.AutoSize = true;
            this.ckbAutorizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAutorizo.Location = new System.Drawing.Point(43, 219);
            this.ckbAutorizo.Name = "ckbAutorizo";
            this.ckbAutorizo.Size = new System.Drawing.Size(87, 24);
            this.ckbAutorizo.TabIndex = 4;
            this.ckbAutorizo.Text = "Autorizo";
            this.ckbAutorizo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(391, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 50);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(513, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(146, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(529, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 50);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.autorizo});
            this.dgvCadastro.Location = new System.Drawing.Point(0, 0);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(641, 345);
            this.dgvCadastro.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // autorizo
            // 
            this.autorizo.HeaderText = "Autorizo envio de propagandas";
            this.autorizo.Name = "autorizo";
            // 
            // frmTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbcCadastro);
            this.Name = "frmTabList";
            this.Text = "frmTabList";
            this.tbcCadastro.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox ckbAutorizo;
        private System.Windows.Forms.Label lblPropaganda;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorizo;
    }
}