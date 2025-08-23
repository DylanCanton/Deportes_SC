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
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.lblPartidoSel = new System.Windows.Forms.Label();
            this.btnGuardarResultado = new System.Windows.Forms.Button();
            this.cmb_jugador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudMinuto1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFases = new System.Windows.Forms.ComboBox();
            this.lbl_Fase = new System.Windows.Forms.Label();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbVisita = new System.Windows.Forms.RadioButton();
            this.lblEquipoCasa = new System.Windows.Forms.Label();
            this.lblEquipoVisita = new System.Windows.Forms.Label();
            this.btnAgregarSancion = new System.Windows.Forms.Button();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto1)).BeginInit();
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
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(61, 67);
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
            this.cmbTorneo.Location = new System.Drawing.Point(143, 67);
            this.cmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(196, 29);
            this.cmbTorneo.TabIndex = 87;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(65, 153);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowHeadersWidth = 51;
            this.dgvPartidos.RowTemplate.Height = 24;
            this.dgvPartidos.Size = new System.Drawing.Size(867, 368);
            this.dgvPartidos.TabIndex = 88;
            this.dgvPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellDoubleClick);
            // 
            // lblPartidoSel
            // 
            this.lblPartidoSel.AutoSize = true;
            this.lblPartidoSel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidoSel.Location = new System.Drawing.Point(323, 112);
            this.lblPartidoSel.Name = "lblPartidoSel";
            this.lblPartidoSel.Size = new System.Drawing.Size(338, 24);
            this.lblPartidoSel.TabIndex = 91;
            this.lblPartidoSel.Text = "Partido Seleccionado: (Ninguno)";
            this.lblPartidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarResultado
            // 
            this.btnGuardarResultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarResultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarResultado.Image")));
            this.btnGuardarResultado.Location = new System.Drawing.Point(327, 822);
            this.btnGuardarResultado.Name = "btnGuardarResultado";
            this.btnGuardarResultado.Size = new System.Drawing.Size(304, 62);
            this.btnGuardarResultado.TabIndex = 95;
            this.btnGuardarResultado.Text = "Guardar Resultado";
            this.btnGuardarResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarResultado.UseVisualStyleBackColor = false;
            this.btnGuardarResultado.Click += new System.EventHandler(this.btnGuardarResultado_Click);
            // 
            // cmb_jugador
            // 
            this.cmb_jugador.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_jugador.FormattingEnabled = true;
            this.cmb_jugador.Location = new System.Drawing.Point(446, 614);
            this.cmb_jugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_jugador.Name = "cmb_jugador";
            this.cmb_jugador.Size = new System.Drawing.Size(124, 29);
            this.cmb_jugador.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Jugador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Gol",
            "Tarjeta Amarilla",
            "Tarjeta Roja"});
            this.cmbTipo.Location = new System.Drawing.Point(446, 672);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(124, 29);
            this.cmbTipo.TabIndex = 105;
            // 
            // nudMinuto1
            // 
            this.nudMinuto1.Location = new System.Drawing.Point(446, 738);
            this.nudMinuto1.Name = "nudMinuto1";
            this.nudMinuto1.Size = new System.Drawing.Size(120, 22);
            this.nudMinuto1.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 738);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 108;
            this.label5.Text = "Minuto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFases
            // 
            this.cmbFases.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbFases.FormattingEnabled = true;
            this.cmbFases.Items.AddRange(new object[] {
            "Regular",
            "Final"});
            this.cmbFases.Location = new System.Drawing.Point(465, 67);
            this.cmbFases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFases.Name = "cmbFases";
            this.cmbFases.Size = new System.Drawing.Size(196, 29);
            this.cmbFases.TabIndex = 113;
            this.cmbFases.SelectedIndexChanged += new System.EventHandler(this.cmbFases_SelectedIndexChanged);
            // 
            // lbl_Fase
            // 
            this.lbl_Fase.AutoSize = true;
            this.lbl_Fase.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fase.Location = new System.Drawing.Point(383, 67);
            this.lbl_Fase.Name = "lbl_Fase";
            this.lbl_Fase.Size = new System.Drawing.Size(55, 21);
            this.lbl_Fase.TabIndex = 112;
            this.lbl_Fase.Text = "Fase:";
            this.lbl_Fase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(279, 579);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(60, 20);
            this.rbCasa.TabIndex = 114;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.rbCasa_CheckedChanged);
            // 
            // rbVisita
            // 
            this.rbVisita.AutoSize = true;
            this.rbVisita.Location = new System.Drawing.Point(570, 579);
            this.rbVisita.Name = "rbVisita";
            this.rbVisita.Size = new System.Drawing.Size(61, 20);
            this.rbVisita.TabIndex = 115;
            this.rbVisita.TabStop = true;
            this.rbVisita.Text = "Visita";
            this.rbVisita.UseVisualStyleBackColor = true;
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
            // btnAgregarSancion
            // 
            this.btnAgregarSancion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregarSancion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSancion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarSancion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSancion.Image")));
            this.btnAgregarSancion.Location = new System.Drawing.Point(465, 766);
            this.btnAgregarSancion.Name = "btnAgregarSancion";
            this.btnAgregarSancion.Size = new System.Drawing.Size(69, 50);
            this.btnAgregarSancion.TabIndex = 118;
            this.btnAgregarSancion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarSancion.UseVisualStyleBackColor = false;
            this.btnAgregarSancion.Click += new System.EventHandler(this.btnAgregarSancion_Click);
            // 
            // FrmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btnAgregarSancion);
            this.Controls.Add(this.lblEquipoVisita);
            this.Controls.Add(this.lblEquipoCasa);
            this.Controls.Add(this.rbVisita);
            this.Controls.Add(this.rbCasa);
            this.Controls.Add(this.cmbFases);
            this.Controls.Add(this.lbl_Fase);
            this.Controls.Add(this.nudMinuto1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_jugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarResultado);
            this.Controls.Add(this.lblPartidoSel);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.pnl_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPartidos";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Label lblPartidoSel;
        private System.Windows.Forms.Button btnGuardarResultado;
        private System.Windows.Forms.ComboBox cmb_jugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudMinuto1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFases;
        private System.Windows.Forms.Label lbl_Fase;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.RadioButton rbVisita;
        private System.Windows.Forms.Label lblEquipoCasa;
        private System.Windows.Forms.Label lblEquipoVisita;
        private System.Windows.Forms.Button btnAgregarSancion;
    }
}