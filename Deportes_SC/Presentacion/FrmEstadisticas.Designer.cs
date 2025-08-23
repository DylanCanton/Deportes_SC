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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.PictureBox();
            this.tab_Reportes = new System.Windows.Forms.TabControl();
            this.tab_Equipos = new System.Windows.Forms.TabPage();
            this.tab_Goleadores = new System.Windows.Forms.TabPage();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.splitGoleadores = new System.Windows.Forms.SplitContainer();
            this.dgvGoleadores = new System.Windows.Forms.DataGridView();
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_Sanciones = new System.Windows.Forms.TabPage();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            this.tab_Reportes.SuspendLayout();
            this.tab_Goleadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGoleadores)).BeginInit();
            this.splitGoleadores.Panel1.SuspendLayout();
            this.splitGoleadores.Panel2.SuspendLayout();
            this.splitGoleadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.tab_Goleadores.Controls.Add(this.cmbTorneo);
            this.tab_Goleadores.Controls.Add(this.lblTorneo);
            this.tab_Goleadores.Controls.Add(this.splitGoleadores);
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
            this.cmbTorneo.Location = new System.Drawing.Point(388, 14);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(196, 29);
            this.cmbTorneo.TabIndex = 89;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(306, 14);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(76, 21);
            this.lblTorneo.TabIndex = 88;
            this.lblTorneo.Text = "Torneo:";
            this.lblTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitGoleadores
            // 
            this.splitGoleadores.Location = new System.Drawing.Point(8, 48);
            this.splitGoleadores.Name = "splitGoleadores";
            // 
            // splitGoleadores.Panel1
            // 
            this.splitGoleadores.Panel1.Controls.Add(this.dgvGoleadores);
            // 
            // splitGoleadores.Panel2
            // 
            this.splitGoleadores.Panel2.Controls.Add(this.chartTop);
            this.splitGoleadores.Size = new System.Drawing.Size(981, 871);
            this.splitGoleadores.SplitterDistance = 532;
            this.splitGoleadores.TabIndex = 0;
            // 
            // dgvGoleadores
            // 
            this.dgvGoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoleadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoleadores.Location = new System.Drawing.Point(0, 0);
            this.dgvGoleadores.Name = "dgvGoleadores";
            this.dgvGoleadores.RowHeadersWidth = 51;
            this.dgvGoleadores.RowTemplate.Height = 24;
            this.dgvGoleadores.Size = new System.Drawing.Size(532, 871);
            this.dgvGoleadores.TabIndex = 0;
            // 
            // chartTop
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea1);
            this.chartTop.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTop.Legends.Add(legend1);
            this.chartTop.Location = new System.Drawing.Point(0, 0);
            this.chartTop.Name = "chartTop";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTop.Series.Add(series1);
            this.chartTop.Size = new System.Drawing.Size(445, 871);
            this.chartTop.TabIndex = 0;
            this.chartTop.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            this.tab_Reportes.ResumeLayout(false);
            this.tab_Goleadores.ResumeLayout(false);
            this.tab_Goleadores.PerformLayout();
            this.splitGoleadores.Panel1.ResumeLayout(false);
            this.splitGoleadores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGoleadores)).EndInit();
            this.splitGoleadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.TabControl tab_Reportes;
        private System.Windows.Forms.TabPage tab_Equipos;
        private System.Windows.Forms.TabPage tab_Goleadores;
        private System.Windows.Forms.TabPage tab_Sanciones;
        private System.Windows.Forms.SplitContainer splitGoleadores;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        private System.Windows.Forms.DataGridView dgvGoleadores;
    }
}