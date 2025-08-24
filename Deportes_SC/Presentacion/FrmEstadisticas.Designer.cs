namespace Deportes_SC.Presentacion
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.PictureBox();
            this.tab_Reportes = new System.Windows.Forms.TabControl();
            this.tab_Equipos = new System.Windows.Forms.TabPage();
            this.tab_Goleadores = new System.Windows.Forms.TabPage();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.tab_Sanciones = new System.Windows.Forms.TabPage();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.dgvGoleadores = new System.Windows.Forms.DataGridView();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            this.tab_Reportes.SuspendLayout();
            this.tab_Equipos.SuspendLayout();
            this.tab_Goleadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Controls.Add(this.cmbTorneo);
            this.pnl_superior.Controls.Add(this.lblTorneo);
            this.pnl_superior.Controls.Add(this.volver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(1000, 44);
            this.pnl_superior.TabIndex = 46;
            // 
            // volver
            // 
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(3, 3);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(60, 38);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volver.TabIndex = 0;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // tab_Reportes
            // 
            this.tab_Reportes.Controls.Add(this.tab_Equipos);
            this.tab_Reportes.Controls.Add(this.tab_Goleadores);
            this.tab_Reportes.Controls.Add(this.tab_Sanciones);
            this.tab_Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Reportes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Reportes.Location = new System.Drawing.Point(0, 44);
            this.tab_Reportes.Name = "tab_Reportes";
            this.tab_Reportes.SelectedIndex = 0;
            this.tab_Reportes.Size = new System.Drawing.Size(1000, 956);
            this.tab_Reportes.TabIndex = 47;
            this.tab_Reportes.SelectedIndexChanged += new System.EventHandler(this.tab_Reportes_SelectedIndexChanged);
            // 
            // tab_Equipos
            // 
            this.tab_Equipos.Controls.Add(this.dgvPosiciones);
            this.tab_Equipos.Location = new System.Drawing.Point(4, 30);
            this.tab_Equipos.Name = "tab_Equipos";
            this.tab_Equipos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Equipos.Size = new System.Drawing.Size(992, 922);
            this.tab_Equipos.TabIndex = 0;
            this.tab_Equipos.Text = "Posiciones";
            this.tab_Equipos.UseVisualStyleBackColor = true;
            // 
            // tab_Goleadores
            // 
            this.tab_Goleadores.Controls.Add(this.dgvGoleadores);
            this.tab_Goleadores.Location = new System.Drawing.Point(4, 30);
            this.tab_Goleadores.Name = "tab_Goleadores";
            this.tab_Goleadores.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Goleadores.Size = new System.Drawing.Size(992, 922);
            this.tab_Goleadores.TabIndex = 1;
            this.tab_Goleadores.Text = "Goleadores";
            this.tab_Goleadores.UseVisualStyleBackColor = true;
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(396, 10);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(261, 29);
            this.cmbTorneo.TabIndex = 89;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(314, 10);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(76, 21);
            this.lblTorneo.TabIndex = 88;
            this.lblTorneo.Text = "Torneo:";
            this.lblTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Sanciones
            // 
            this.tab_Sanciones.Location = new System.Drawing.Point(4, 30);
            this.tab_Sanciones.Name = "tab_Sanciones";
            this.tab_Sanciones.Size = new System.Drawing.Size(992, 922);
            this.tab_Sanciones.TabIndex = 2;
            this.tab_Sanciones.Text = "Sanciones";
            this.tab_Sanciones.UseVisualStyleBackColor = true;
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosiciones.Location = new System.Drawing.Point(3, 3);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersWidth = 51;
            this.dgvPosiciones.RowTemplate.Height = 24;
            this.dgvPosiciones.Size = new System.Drawing.Size(986, 916);
            this.dgvPosiciones.TabIndex = 90;
            // 
            // dgvGoleadores
            // 
            this.dgvGoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoleadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoleadores.Location = new System.Drawing.Point(3, 3);
            this.dgvGoleadores.Name = "dgvGoleadores";
            this.dgvGoleadores.RowHeadersWidth = 51;
            this.dgvGoleadores.RowTemplate.Height = 24;
            this.dgvGoleadores.Size = new System.Drawing.Size(986, 916);
            this.dgvGoleadores.TabIndex = 1;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.tab_Reportes);
            this.Controls.Add(this.pnl_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.pnl_superior.ResumeLayout(false);
            this.pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            this.tab_Reportes.ResumeLayout(false);
            this.tab_Equipos.ResumeLayout(false);
            this.tab_Goleadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.TabControl tab_Reportes;
        private System.Windows.Forms.TabPage tab_Equipos;
        private System.Windows.Forms.TabPage tab_Goleadores;
        private System.Windows.Forms.TabPage tab_Sanciones;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridView dgvGoleadores;
    }
}