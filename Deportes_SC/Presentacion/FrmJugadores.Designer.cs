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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_nacimiento = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_equipo = new System.Windows.Forms.ComboBox();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.pic_fondo = new System.Windows.Forms.PictureBox();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.cmb_posicion = new System.Windows.Forms.ComboBox();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.txt_dorsal = new System.Windows.Forms.TextBox();
            this.lbl_dorsal = new System.Windows.Forms.Label();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(592, 381);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(146, 75);
            this.btn_eliminar.TabIndex = 82;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(670, 303);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(146, 75);
            this.btn_modificar.TabIndex = 81;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(518, 303);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(146, 75);
            this.btn_guardar.TabIndex = 80;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(293, 315);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(201, 22);
            this.dtp_fechaNacimiento.TabIndex = 79;
            this.dtp_fechaNacimiento.Value = new System.DateTime(2025, 8, 7, 0, 0, 0, 0);
            // 
            // lbl_nacimiento
            // 
            this.lbl_nacimiento.AutoSize = true;
            this.lbl_nacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nacimiento.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nacimiento.Location = new System.Drawing.Point(299, 280);
            this.lbl_nacimiento.Name = "lbl_nacimiento";
            this.lbl_nacimiento.Size = new System.Drawing.Size(192, 21);
            this.lbl_nacimiento.TabIndex = 78;
            this.lbl_nacimiento.Text = "Fecha de nacimiento:";
            this.lbl_nacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_nombre.Location = new System.Drawing.Point(29, 318);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(196, 28);
            this.txt_nombre.TabIndex = 77;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nombre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(34, 283);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(182, 21);
            this.lbl_nombre.TabIndex = 76;
            this.lbl_nombre.Text = "Nombre de jugador:";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_cedula.Location = new System.Drawing.Point(29, 207);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(196, 28);
            this.txt_cedula.TabIndex = 75;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(29, 101);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 28);
            this.txt_id.TabIndex = 74;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_cedula.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cedula.Location = new System.Drawing.Point(84, 171);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(74, 21);
            this.lbl_cedula.TabIndex = 73;
            this.lbl_cedula.Text = "Cedula:";
            this.lbl_cedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Location = new System.Drawing.Point(56, 67);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(135, 21);
            this.lbl_id.TabIndex = 72;
            this.lbl_id.Text = "Identificacion:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_equipo
            // 
            this.cmb_equipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_equipo.FormattingEnabled = true;
            this.cmb_equipo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_equipo.Location = new System.Drawing.Point(293, 416);
            this.cmb_equipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_equipo.Name = "cmb_equipo";
            this.cmb_equipo.Size = new System.Drawing.Size(197, 29);
            this.cmb_equipo.TabIndex = 84;
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_equipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_equipo.Location = new System.Drawing.Point(348, 377);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(75, 21);
            this.lbl_equipo.TabIndex = 83;
            this.lbl_equipo.Text = "Equipo:";
            this.lbl_equipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_genero
            // 
            this.cmb_genero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_genero.Location = new System.Drawing.Point(29, 416);
            this.cmb_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(196, 29);
            this.cmb_genero.TabIndex = 86;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_genero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_genero.Location = new System.Drawing.Point(84, 381);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(78, 21);
            this.lbl_genero.TabIndex = 85;
            this.lbl_genero.Text = "Genero:";
            this.lbl_genero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_fondo
            // 
            this.pic_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_fondo.Image = ((System.Drawing.Image)(resources.GetObject("pic_fondo.Image")));
            this.pic_fondo.Location = new System.Drawing.Point(0, 0);
            this.pic_fondo.Name = "pic_fondo";
            this.pic_fondo.Size = new System.Drawing.Size(819, 972);
            this.pic_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fondo.TabIndex = 87;
            this.pic_fondo.TabStop = false;
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Location = new System.Drawing.Point(12, 479);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.RowHeadersWidth = 51;
            this.dgv_jugadores.RowTemplate.Height = 24;
            this.dgv_jugadores.Size = new System.Drawing.Size(795, 353);
            this.dgv_jugadores.TabIndex = 88;
            this.dgv_jugadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_jugadores_CellDoubleClick);
            // 
            // cmb_posicion
            // 
            this.cmb_posicion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_posicion.FormattingEnabled = true;
            this.cmb_posicion.Items.AddRange(new object[] {
            "Portero",
            "Defensa",
            "Mediocampista",
            "Delantero"});
            this.cmb_posicion.Location = new System.Drawing.Point(298, 101);
            this.cmb_posicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_posicion.Name = "cmb_posicion";
            this.cmb_posicion.Size = new System.Drawing.Size(196, 29);
            this.cmb_posicion.TabIndex = 90;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_posicion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_posicion.Location = new System.Drawing.Point(353, 66);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(88, 21);
            this.lbl_posicion.TabIndex = 89;
            this.lbl_posicion.Text = "Posicion:";
            this.lbl_posicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dorsal
            // 
            this.txt_dorsal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_dorsal.Location = new System.Drawing.Point(293, 207);
            this.txt_dorsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dorsal.Name = "txt_dorsal";
            this.txt_dorsal.Size = new System.Drawing.Size(196, 28);
            this.txt_dorsal.TabIndex = 92;
            // 
            // lbl_dorsal
            // 
            this.lbl_dorsal.AutoSize = true;
            this.lbl_dorsal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_dorsal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dorsal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dorsal.Location = new System.Drawing.Point(298, 172);
            this.lbl_dorsal.Name = "lbl_dorsal";
            this.lbl_dorsal.Size = new System.Drawing.Size(71, 21);
            this.lbl_dorsal.TabIndex = 91;
            this.lbl_dorsal.Text = "Dorsal:";
            this.lbl_dorsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 972);
            this.Controls.Add(this.txt_dorsal);
            this.Controls.Add(this.lbl_dorsal);
            this.Controls.Add(this.cmb_posicion);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.dgv_jugadores);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.cmb_equipo);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.lbl_nacimiento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.lbl_id);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Label lbl_nacimiento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_equipo;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.PictureBox pic_fondo;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.ComboBox cmb_posicion;
        private System.Windows.Forms.Label lbl_posicion;
        private System.Windows.Forms.TextBox txt_dorsal;
        private System.Windows.Forms.Label lbl_dorsal;
    }
}