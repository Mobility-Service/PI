
namespace Mobilitec_Services
{
    partial class frmCadastrosColaboradores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvColaboradoresCadastros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradoresCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColaboradoresCadastros
            // 
            this.dgvColaboradoresCadastros.AllowUserToAddRows = false;
            this.dgvColaboradoresCadastros.AllowUserToDeleteRows = false;
            this.dgvColaboradoresCadastros.AllowUserToResizeColumns = false;
            this.dgvColaboradoresCadastros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvColaboradoresCadastros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColaboradoresCadastros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvColaboradoresCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradoresCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColaboradoresCadastros.Location = new System.Drawing.Point(0, 0);
            this.dgvColaboradoresCadastros.Name = "dgvColaboradoresCadastros";
            this.dgvColaboradoresCadastros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvColaboradoresCadastros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColaboradoresCadastros.Size = new System.Drawing.Size(800, 450);
            this.dgvColaboradoresCadastros.TabIndex = 1;
            this.dgvColaboradoresCadastros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradoresCadastros_CellContentClick);
            this.dgvColaboradoresCadastros.Click += new System.EventHandler(this.dgvColaboradoresCadastros_Click);
            // 
            // frmCadastrosColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvColaboradoresCadastros);
            this.Name = "frmCadastrosColaboradores";
            this.Text = "frmCadastrosColaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradoresCadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaboradoresCadastros;
    }
}