namespace Deportes_SC.Presentacion
{
    partial class FrmPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartidos));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.lblVisita = new System.Windows.Forms.Label();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblPartidoSel = new System.Windows.Forms.Label();
            this.nudGolesCasa = new System.Windows.Forms.NumericUpDown();
            this.nudGolesVisita = new System.Windows.Forms.NumericUpDown();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnGuardarResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGolesCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGolesVisita)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(840, 44);
            this.pnl_superior.TabIndex = 46;
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(222, 82);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(76, 21);
            this.lblTorneo.TabIndex = 48;
            this.lblTorneo.Text = "Torneo:";
            this.lblTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(304, 82);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(196, 29);
            this.cmbTorneo.TabIndex = 87;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(71, 163);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowHeadersWidth = 51;
            this.dgvPartidos.RowTemplate.Height = 24;
            this.dgvPartidos.Size = new System.Drawing.Size(646, 336);
            this.dgvPartidos.TabIndex = 88;
            this.dgvPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellDoubleClick);
            // 
            // lblVisita
            // 
            this.lblVisita.AutoSize = true;
            this.lblVisita.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisita.Location = new System.Drawing.Point(418, 626);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(63, 21);
            this.lblVisita.TabIndex = 89;
            this.lblVisita.Text = "Visita:";
            this.lblVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.Location = new System.Drawing.Point(169, 626);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(56, 21);
            this.lblCasa.TabIndex = 90;
            this.lblCasa.Text = "Casa:";
            this.lblCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartidoSel
            // 
            this.lblPartidoSel.AutoSize = true;
            this.lblPartidoSel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidoSel.Location = new System.Drawing.Point(251, 549);
            this.lblPartidoSel.Name = "lblPartidoSel";
            this.lblPartidoSel.Size = new System.Drawing.Size(290, 21);
            this.lblPartidoSel.TabIndex = 91;
            this.lblPartidoSel.Text = "Partido Seleccionado: (Ninguno)";
            this.lblPartidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudGolesCasa
            // 
            this.nudGolesCasa.Location = new System.Drawing.Point(240, 626);
            this.nudGolesCasa.Name = "nudGolesCasa";
            this.nudGolesCasa.Size = new System.Drawing.Size(120, 22);
            this.nudGolesCasa.TabIndex = 92;
            // 
            // nudGolesVisita
            // 
            this.nudGolesVisita.Location = new System.Drawing.Point(493, 628);
            this.nudGolesVisita.Name = "nudGolesVisita";
            this.nudGolesVisita.Size = new System.Drawing.Size(120, 22);
            this.nudGolesVisita.TabIndex = 93;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRefrescar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(521, 65);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(163, 58);
            this.btnRefrescar.TabIndex = 94;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnGuardarResultado
            // 
            this.btnGuardarResultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarResultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarResultado.Image")));
            this.btnGuardarResultado.Location = new System.Drawing.Point(273, 682);
            this.btnGuardarResultado.Name = "btnGuardarResultado";
            this.btnGuardarResultado.Size = new System.Drawing.Size(242, 62);
            this.btnGuardarResultado.TabIndex = 95;
            this.btnGuardarResultado.Text = "Guardar Resultado";
            this.btnGuardarResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarResultado.UseVisualStyleBackColor = false;
            this.btnGuardarResultado.Click += new System.EventHandler(this.btnGuardarResultado_Click);
            // 
            // FrmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 900);
            this.Controls.Add(this.btnGuardarResultado);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.nudGolesVisita);
            this.Controls.Add(this.nudGolesCasa);
            this.Controls.Add(this.lblPartidoSel);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lblVisita);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.pnl_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPartidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGolesCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGolesVisita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblPartidoSel;
        private System.Windows.Forms.NumericUpDown nudGolesCasa;
        private System.Windows.Forms.NumericUpDown nudGolesVisita;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnGuardarResultado;
    }
}