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
            this.volver = new System.Windows.Forms.PictureBox();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.lblPartidoSel = new System.Windows.Forms.Label();
            this.cmb_jugador = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudMinuto1 = new System.Windows.Forms.NumericUpDown();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbVisita = new System.Windows.Forms.RadioButton();
            this.lblEquipoCasa = new System.Windows.Forms.Label();
            this.lblEquipoVisita = new System.Windows.Forms.Label();
            this.btnGenerarGranFinal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardaResultado = new System.Windows.Forms.PictureBox();
            this.btnAgregaSancion = new System.Windows.Forms.PictureBox();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarGranFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaSancion)).BeginInit();
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
            this.volver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(3, 3);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(60, 38);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volver.TabIndex = 112;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.volver_Click_1);
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(145, 162);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(331, 29);
            this.cmbTorneo.TabIndex = 87;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(60, 219);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowHeadersWidth = 51;
            this.dgvPartidos.RowTemplate.Height = 24;
            this.dgvPartidos.Size = new System.Drawing.Size(867, 368);
            this.dgvPartidos.TabIndex = 88;
            this.dgvPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellContentClick);
            this.dgvPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellDoubleClick);
            // 
            // lblPartidoSel
            // 
            this.lblPartidoSel.AutoSize = true;
            this.lblPartidoSel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPartidoSel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidoSel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPartidoSel.Location = new System.Drawing.Point(575, 162);
            this.lblPartidoSel.Name = "lblPartidoSel";
            this.lblPartidoSel.Size = new System.Drawing.Size(338, 24);
            this.lblPartidoSel.TabIndex = 91;
            this.lblPartidoSel.Text = "Partido Seleccionado: (Ninguno)";
            this.lblPartidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_jugador
            // 
            this.cmb_jugador.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_jugador.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_jugador.FormattingEnabled = true;
            this.cmb_jugador.Location = new System.Drawing.Point(327, 611);
            this.cmb_jugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_jugador.Name = "cmb_jugador";
            this.cmb_jugador.Size = new System.Drawing.Size(272, 29);
            this.cmb_jugador.TabIndex = 97;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Gol",
            "Tarjeta Amarilla",
            "Tarjeta Roja"});
            this.cmbTipo.Location = new System.Drawing.Point(327, 688);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(272, 29);
            this.cmbTipo.TabIndex = 105;
            // 
            // nudMinuto1
            // 
            this.nudMinuto1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nudMinuto1.Location = new System.Drawing.Point(327, 781);
            this.nudMinuto1.Name = "nudMinuto1";
            this.nudMinuto1.Size = new System.Drawing.Size(272, 22);
            this.nudMinuto1.TabIndex = 109;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.rbCasa.Location = new System.Drawing.Point(629, 611);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(60, 20);
            this.rbCasa.TabIndex = 114;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = false;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.rbCasa_CheckedChanged);
            // 
            // rbVisita
            // 
            this.rbVisita.AutoSize = true;
            this.rbVisita.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.rbVisita.Location = new System.Drawing.Point(725, 611);
            this.rbVisita.Name = "rbVisita";
            this.rbVisita.Size = new System.Drawing.Size(61, 20);
            this.rbVisita.TabIndex = 115;
            this.rbVisita.TabStop = true;
            this.rbVisita.Text = "Visita";
            this.rbVisita.UseVisualStyleBackColor = false;
            this.rbVisita.CheckedChanged += new System.EventHandler(this.rbVisita_CheckedChanged);
            // 
            // lblEquipoCasa
            // 
            this.lblEquipoCasa.AutoSize = true;
            this.lblEquipoCasa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoCasa.Location = new System.Drawing.Point(253, 535);
            this.lblEquipoCasa.Name = "lblEquipoCasa";
            this.lblEquipoCasa.Size = new System.Drawing.Size(0, 21);
            this.lblEquipoCasa.TabIndex = 116;
            this.lblEquipoCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipoVisita
            // 
            this.lblEquipoVisita.AutoSize = true;
            this.lblEquipoVisita.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisita.Location = new System.Drawing.Point(575, 535);
            this.lblEquipoVisita.Name = "lblEquipoVisita";
            this.lblEquipoVisita.Size = new System.Drawing.Size(0, 21);
            this.lblEquipoVisita.TabIndex = 117;
            this.lblEquipoVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerarGranFinal
            // 
            this.btnGenerarGranFinal.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarGranFinal.Image")));
            this.btnGenerarGranFinal.Location = new System.Drawing.Point(501, 900);
            this.btnGenerarGranFinal.Name = "btnGenerarGranFinal";
            this.btnGenerarGranFinal.Size = new System.Drawing.Size(285, 88);
            this.btnGenerarGranFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGenerarGranFinal.TabIndex = 119;
            this.btnGenerarGranFinal.TabStop = false;
            this.btnGenerarGranFinal.Click += new System.EventHandler(this.btnGenerarGranFinal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 962);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardaResultado
            // 
            this.btnGuardaResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardaResultado.Image")));
            this.btnGuardaResultado.Location = new System.Drawing.Point(191, 900);
            this.btnGuardaResultado.Name = "btnGuardaResultado";
            this.btnGuardaResultado.Size = new System.Drawing.Size(285, 88);
            this.btnGuardaResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardaResultado.TabIndex = 121;
            this.btnGuardaResultado.TabStop = false;
            this.btnGuardaResultado.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAgregaSancion
            // 
            this.btnAgregaSancion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaSancion.Image")));
            this.btnAgregaSancion.Location = new System.Drawing.Point(451, 809);
            this.btnAgregaSancion.Name = "btnAgregaSancion";
            this.btnAgregaSancion.Size = new System.Drawing.Size(75, 85);
            this.btnAgregaSancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregaSancion.TabIndex = 122;
            this.btnAgregaSancion.TabStop = false;
            this.btnAgregaSancion.Click += new System.EventHandler(this.btnAgregaSancion_Click);
            // 
            // FrmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btnAgregaSancion);
            this.Controls.Add(this.btnGuardaResultado);
            this.Controls.Add(this.btnGenerarGranFinal);
            this.Controls.Add(this.lblEquipoVisita);
            this.Controls.Add(this.lblEquipoCasa);
            this.Controls.Add(this.rbVisita);
            this.Controls.Add(this.rbCasa);
            this.Controls.Add(this.nudMinuto1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmb_jugador);
            this.Controls.Add(this.lblPartidoSel);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPartidos";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarGranFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaSancion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Label lblPartidoSel;
        private System.Windows.Forms.ComboBox cmb_jugador;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudMinuto1;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.RadioButton rbVisita;
        private System.Windows.Forms.Label lblEquipoCasa;
        private System.Windows.Forms.Label lblEquipoVisita;
        private System.Windows.Forms.PictureBox btnGenerarGranFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnGuardaResultado;
        private System.Windows.Forms.PictureBox btnAgregaSancion;
    }
}