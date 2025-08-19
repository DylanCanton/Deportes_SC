namespace Deportes_SC.Presentacion
{
    partial class FrmJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJugadores));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.PictureBox();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_equipo = new System.Windows.Forms.ComboBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.pic_fondo = new System.Windows.Forms.PictureBox();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.cmb_posicion = new System.Windows.Forms.ComboBox();
            this.txt_dorsal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Controls.Add(this.volver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(819, 44);
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
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(3, 487);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(201, 22);
            this.dtp_fechaNacimiento.TabIndex = 79;
            this.dtp_fechaNacimiento.Value = new System.DateTime(2025, 8, 7, 0, 0, 0, 0);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_nombre.Location = new System.Drawing.Point(309, 242);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(196, 28);
            this.txt_nombre.TabIndex = 77;
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_cedula.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_cedula.Location = new System.Drawing.Point(8, 374);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(196, 28);
            this.txt_cedula.TabIndex = 75;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(8, 242);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 28);
            this.txt_id.TabIndex = 74;
            // 
            // cmb_equipo
            // 
            this.cmb_equipo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_equipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_equipo.FormattingEnabled = true;
            this.cmb_equipo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_equipo.Location = new System.Drawing.Point(297, 480);
            this.cmb_equipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_equipo.Name = "cmb_equipo";
            this.cmb_equipo.Size = new System.Drawing.Size(197, 29);
            this.cmb_equipo.TabIndex = 84;
            // 
            // cmb_genero
            // 
            this.cmb_genero.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_genero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_genero.Location = new System.Drawing.Point(593, 374);
            this.cmb_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(196, 29);
            this.cmb_genero.TabIndex = 86;
            // 
            // pic_fondo
            // 
            this.pic_fondo.Image = ((System.Drawing.Image)(resources.GetObject("pic_fondo.Image")));
            this.pic_fondo.Location = new System.Drawing.Point(0, 41);
            this.pic_fondo.Name = "pic_fondo";
            this.pic_fondo.Size = new System.Drawing.Size(819, 931);
            this.pic_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fondo.TabIndex = 87;
            this.pic_fondo.TabStop = false;
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Location = new System.Drawing.Point(31, 570);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.RowHeadersWidth = 51;
            this.dgv_jugadores.RowTemplate.Height = 24;
            this.dgv_jugadores.Size = new System.Drawing.Size(758, 287);
            this.dgv_jugadores.TabIndex = 88;
            this.dgv_jugadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_jugadores_CellDoubleClick);
            // 
            // cmb_posicion
            // 
            this.cmb_posicion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_posicion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_posicion.FormattingEnabled = true;
            this.cmb_posicion.Items.AddRange(new object[] {
            "Portero",
            "Defensa",
            "Mediocampista",
            "Delantero"});
            this.cmb_posicion.Location = new System.Drawing.Point(593, 241);
            this.cmb_posicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_posicion.Name = "cmb_posicion";
            this.cmb_posicion.Size = new System.Drawing.Size(196, 29);
            this.cmb_posicion.TabIndex = 90;
            // 
            // txt_dorsal
            // 
            this.txt_dorsal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_dorsal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_dorsal.Location = new System.Drawing.Point(295, 374);
            this.txt_dorsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dorsal.Name = "txt_dorsal";
            this.txt_dorsal.Size = new System.Drawing.Size(196, 28);
            this.txt_dorsal.TabIndex = 92;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(104, 878);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 64);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 95;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(309, 878);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(196, 64);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 94;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(511, 878);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(196, 64);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistrar.TabIndex = 93;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 972);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txt_dorsal);
            this.Controls.Add(this.cmb_posicion);
            this.Controls.Add(this.dgv_jugadores);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.cmb_equipo);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.pic_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJugadores";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_equipo;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.PictureBox pic_fondo;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.ComboBox cmb_posicion;
        private System.Windows.Forms.TextBox txt_dorsal;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnRegistrar;
    }
}