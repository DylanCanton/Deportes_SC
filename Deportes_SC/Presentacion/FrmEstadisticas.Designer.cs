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
            this.tab_Sanciones = new System.Windows.Forms.TabPage();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            this.tab_Reportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Controls.Add(this.volver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(840, 44);
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
            this.tab_Reportes.Size = new System.Drawing.Size(840, 856);
            this.tab_Reportes.TabIndex = 47;
            // 
            // tab_Equipos
            // 
            this.tab_Equipos.Location = new System.Drawing.Point(4, 30);
            this.tab_Equipos.Name = "tab_Equipos";
            this.tab_Equipos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Equipos.Size = new System.Drawing.Size(832, 822);
            this.tab_Equipos.TabIndex = 0;
            this.tab_Equipos.Text = "Posiciones";
            this.tab_Equipos.UseVisualStyleBackColor = true;
            // 
            // tab_Goleadores
            // 
            this.tab_Goleadores.Location = new System.Drawing.Point(4, 25);
            this.tab_Goleadores.Name = "tab_Goleadores";
            this.tab_Goleadores.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Goleadores.Size = new System.Drawing.Size(832, 827);
            this.tab_Goleadores.TabIndex = 1;
            this.tab_Goleadores.Text = "Goleadores";
            this.tab_Goleadores.UseVisualStyleBackColor = true;
            // 
            // tab_Sanciones
            // 
            this.tab_Sanciones.Location = new System.Drawing.Point(4, 25);
            this.tab_Sanciones.Name = "tab_Sanciones";
            this.tab_Sanciones.Size = new System.Drawing.Size(832, 827);
            this.tab_Sanciones.TabIndex = 2;
            this.tab_Sanciones.Text = "Sanciones";
            this.tab_Sanciones.UseVisualStyleBackColor = true;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 900);
            this.Controls.Add(this.tab_Reportes);
            this.Controls.Add(this.pnl_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            this.tab_Reportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.TabControl tab_Reportes;
        private System.Windows.Forms.TabPage tab_Equipos;
        private System.Windows.Forms.TabPage tab_Goleadores;
        private System.Windows.Forms.TabPage tab_Sanciones;
    }
}