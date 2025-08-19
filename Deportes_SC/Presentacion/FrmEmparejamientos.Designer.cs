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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmparejamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(294, 150);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(196, 29);
            this.cmbTorneo.TabIndex = 89;
            // 
            // dgvEmparejamientos
            // 
            this.dgvEmparejamientos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvEmparejamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmparejamientos.Location = new System.Drawing.Point(35, 276);
            this.dgvEmparejamientos.Name = "dgvEmparejamientos";
            this.dgvEmparejamientos.RowHeadersWidth = 51;
            this.dgvEmparejamientos.RowTemplate.Height = 24;
            this.dgvEmparejamientos.Size = new System.Drawing.Size(753, 516);
            this.dgvEmparejamientos.TabIndex = 107;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(505, 176);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(134, 46);
            this.btnGenerar.TabIndex = 104;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 816);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(645, 176);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(168, 46);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistrar.TabIndex = 109;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmEmparejamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 853);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvEmparejamientos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmparejamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmparejamientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmparejamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dgvEmparejamientos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnRegistrar;
    }
}