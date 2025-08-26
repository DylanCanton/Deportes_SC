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
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.Registrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(8, 436);
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
            this.txt_cedula.Location = new System.Drawing.Point(8, 340);
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
            this.cmb_equipo.Location = new System.Drawing.Point(309, 434);
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
            this.cmb_genero.Location = new System.Drawing.Point(593, 340);
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
            this.pic_fondo.Size = new System.Drawing.Size(853, 816);
            this.pic_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fondo.TabIndex = 87;
            this.pic_fondo.TabStop = false;
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Location = new System.Drawing.Point(12, 468);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.RowHeadersWidth = 51;
            this.dgv_jugadores.RowTemplate.Height = 24;
            this.dgv_jugadores.Size = new System.Drawing.Size(829, 287);
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
            this.txt_dorsal.Location = new System.Drawing.Point(309, 340);
            this.txt_dorsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dorsal.Name = "txt_dorsal";
            this.txt_dorsal.Size = new System.Drawing.Size(196, 28);
            this.txt_dorsal.TabIndex = 92;
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Controls.Add(this.btnSalir);
            this.pnl_superior.Controls.Add(this.btnVolver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(853, 44);
            this.pnl_superior.TabIndex = 46;
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Location = new System.Drawing.Point(113, 776);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(204, 65);
            this.Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eliminar.TabIndex = 98;
            this.Eliminar.TabStop = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Location = new System.Drawing.Point(323, 776);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(204, 65);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 97;
            this.Editar.TabStop = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Image = ((System.Drawing.Image)(resources.GetObject("Registrar.Image")));
            this.Registrar.Location = new System.Drawing.Point(534, 776);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(204, 65);
            this.Registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Registrar.TabIndex = 96;
            this.Registrar.TabStop = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(802, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 44);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 9;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(0, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(43, 41);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 8;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 853);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Registrar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox Eliminar;
        private System.Windows.Forms.PictureBox Editar;
        private System.Windows.Forms.PictureBox Registrar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnVolver;
    }
}