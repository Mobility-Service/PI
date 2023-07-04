
namespace Mobilitec_Services
{
    partial class frmSplash
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			this.pcbLogo = new System.Windows.Forms.PictureBox();
			this.lblPorcentagem = new System.Windows.Forms.Label();
			this.pgbCarregando = new System.Windows.Forms.ProgressBar();
			this.lblCarregando = new System.Windows.Forms.Label();
			this.tmrSplash = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pcbLogo
			// 
			this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
			this.pcbLogo.Location = new System.Drawing.Point(261, 107);
			this.pcbLogo.Name = "pcbLogo";
			this.pcbLogo.Size = new System.Drawing.Size(262, 229);
			this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbLogo.TabIndex = 0;
			this.pcbLogo.TabStop = false;
			this.pcbLogo.Click += new System.EventHandler(this.pcbLogo_Click);
			// 
			// lblPorcentagem
			// 
			this.lblPorcentagem.AutoSize = true;
			this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPorcentagem.Location = new System.Drawing.Point(376, 363);
			this.lblPorcentagem.Name = "lblPorcentagem";
			this.lblPorcentagem.Size = new System.Drawing.Size(32, 20);
			this.lblPorcentagem.TabIndex = 1;
			this.lblPorcentagem.Text = "0%";
			this.lblPorcentagem.Click += new System.EventHandler(this.lblPorcentagem_Click);
			// 
			// pgbCarregando
			// 
			this.pgbCarregando.Location = new System.Drawing.Point(261, 389);
			this.pgbCarregando.Name = "pgbCarregando";
			this.pgbCarregando.Size = new System.Drawing.Size(262, 23);
			this.pgbCarregando.TabIndex = 2;
			this.pgbCarregando.Click += new System.EventHandler(this.pgbCarregando_Click);
			// 
			// lblCarregando
			// 
			this.lblCarregando.AutoSize = true;
			this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCarregando.Location = new System.Drawing.Point(340, 433);
			this.lblCarregando.Name = "lblCarregando";
			this.lblCarregando.Size = new System.Drawing.Size(105, 20);
			this.lblCarregando.TabIndex = 3;
			this.lblCarregando.Text = "Carregando...";
			this.lblCarregando.Visible = false;
			this.lblCarregando.Click += new System.EventHandler(this.lblCarregando_Click);
			// 
			// tmrSplash
			// 
			this.tmrSplash.Enabled = true;
			this.tmrSplash.Interval = 1000;
			this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.lblCarregando);
			this.Controls.Add(this.pgbCarregando);
			this.Controls.Add(this.lblPorcentagem);
			this.Controls.Add(this.pcbLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mobilite-Services";
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.ProgressBar pgbCarregando;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Timer tmrSplash;
    }
}