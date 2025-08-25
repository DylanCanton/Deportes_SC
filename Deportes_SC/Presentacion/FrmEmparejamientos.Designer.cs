namespace Deportes_SC.Presentacion
{
    partial class FrmEmparejamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmparejamientos));
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvEmparejamientos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.btnGenerarFase = new System.Windows.Forms.PictureBox();
            this.btnGenerarFinal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmparejamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarFase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(300, 138);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(362, 29);
            this.cmbTorneo.TabIndex = 89;
            // 
            // dgvEmparejamientos
            // 
            this.dgvEmparejamientos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvEmparejamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmparejamientos.Location = new System.Drawing.Point(12, 448);
            this.dgvEmparejamientos.Name = "dgvEmparejamientos";
            this.dgvEmparejamientos.RowHeadersWidth = 51;
            this.dgvEmparejamientos.RowTemplate.Height = 24;
            this.dgvEmparejamientos.Size = new System.Drawing.Size(829, 324);
            this.dgvEmparejamientos.TabIndex = 107;
            this.dgvEmparejamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmparejamientos_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 810);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(515, 359);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 50);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistrar.TabIndex = 109;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(853, 44);
            this.pnl_superior.TabIndex = 112;
            // 
            // btnGenerarFase
            // 
            this.btnGenerarFase.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarFase.Image")));
            this.btnGenerarFase.Location = new System.Drawing.Point(333, 359);
            this.btnGenerarFase.Name = "btnGenerarFase";
            this.btnGenerarFase.Size = new System.Drawing.Size(165, 50);
            this.btnGenerarFase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGenerarFase.TabIndex = 114;
            this.btnGenerarFase.TabStop = false;
            this.btnGenerarFase.Click += new System.EventHandler(this.btnGenerarFase_Click);
            // 
            // btnGenerarFinal
            // 
            this.btnGenerarFinal.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarFinal.Image")));
            this.btnGenerarFinal.Location = new System.Drawing.Point(146, 359);
            this.btnGenerarFinal.Name = "btnGenerarFinal";
            this.btnGenerarFinal.Size = new System.Drawing.Size(162, 50);
            this.btnGenerarFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGenerarFinal.TabIndex = 115;
            this.btnGenerarFinal.TabStop = false;
            this.btnGenerarFinal.Click += new System.EventHandler(this.btnGenerarFinal_Click);
            // 
            // FrmEmparejamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 853);
            this.Controls.Add(this.btnGenerarFinal);
            this.Controls.Add(this.btnGenerarFase);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvEmparejamientos);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmparejamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmparejamientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmparejamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarFase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dgvEmparejamientos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnRegistrar;
        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox btnGenerarFase;
        private System.Windows.Forms.PictureBox btnGenerarFinal;
    }
}