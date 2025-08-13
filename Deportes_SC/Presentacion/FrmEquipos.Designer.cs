namespace Deportes_SC.Presentacion
{
    partial class FrmEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipos));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_equipo = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.txt_encargado = new System.Windows.Forms.TextBox();
            this.lbl_encargado = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.cmb_torneo = new System.Windows.Forms.ComboBox();
            this.lbl_torneo = new System.Windows.Forms.Label();
            this.dgv_equipos = new System.Windows.Forms.DataGridView();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipos)).BeginInit();
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
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(639, 321);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 83);
            this.btn_eliminar.TabIndex = 53;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(639, 234);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(166, 83);
            this.btn_modificar.TabIndex = 52;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(639, 147);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(166, 83);
            this.btn_guardar.TabIndex = 51;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_equipo
            // 
            this.txt_equipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_equipo.Location = new System.Drawing.Point(251, 138);
            this.txt_equipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_equipo.Name = "txt_equipo";
            this.txt_equipo.Size = new System.Drawing.Size(196, 28);
            this.txt_equipo.TabIndex = 50;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(251, 67);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 28);
            this.txt_id.TabIndex = 49;
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipo.Location = new System.Drawing.Point(62, 137);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(174, 21);
            this.lbl_equipo.TabIndex = 48;
            this.lbl_equipo.Text = "Nombre de equipo:";
            this.lbl_equipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(85, 66);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(135, 21);
            this.lbl_id.TabIndex = 47;
            this.lbl_id.Text = "Identificacion:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_origen
            // 
            this.txt_origen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_origen.Location = new System.Drawing.Point(251, 210);
            this.txt_origen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(196, 28);
            this.txt_origen.TabIndex = 55;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origen.Location = new System.Drawing.Point(62, 209);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(151, 21);
            this.lbl_origen.TabIndex = 54;
            this.lbl_origen.Text = "Lugar de origen:";
            this.lbl_origen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_encargado
            // 
            this.txt_encargado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_encargado.Location = new System.Drawing.Point(251, 283);
            this.txt_encargado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(196, 28);
            this.txt_encargado.TabIndex = 57;
            // 
            // lbl_encargado
            // 
            this.lbl_encargado.AutoSize = true;
            this.lbl_encargado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encargado.Location = new System.Drawing.Point(77, 286);
            this.lbl_encargado.Name = "lbl_encargado";
            this.lbl_encargado.Size = new System.Drawing.Size(106, 21);
            this.lbl_encargado.TabIndex = 56;
            this.lbl_encargado.Text = "Encargado:";
            this.lbl_encargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_telefono.Location = new System.Drawing.Point(251, 354);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(196, 28);
            this.txt_telefono.TabIndex = 59;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(77, 357);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(91, 21);
            this.lbl_telefono.TabIndex = 58;
            this.lbl_telefono.Text = "Telefono:";
            this.lbl_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_torneo
            // 
            this.cmb_torneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_torneo.FormattingEnabled = true;
            this.cmb_torneo.Location = new System.Drawing.Point(469, 109);
            this.cmb_torneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_torneo.Name = "cmb_torneo";
            this.cmb_torneo.Size = new System.Drawing.Size(196, 29);
            this.cmb_torneo.TabIndex = 86;
            // 
            // lbl_torneo
            // 
            this.lbl_torneo.AutoSize = true;
            this.lbl_torneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_torneo.Location = new System.Drawing.Point(533, 70);
            this.lbl_torneo.Name = "lbl_torneo";
            this.lbl_torneo.Size = new System.Drawing.Size(76, 21);
            this.lbl_torneo.TabIndex = 85;
            this.lbl_torneo.Text = "Torneo:";
            this.lbl_torneo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_equipos
            // 
            this.dgv_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipos.Location = new System.Drawing.Point(66, 436);
            this.dgv_equipos.Name = "dgv_equipos";
            this.dgv_equipos.RowHeadersWidth = 51;
            this.dgv_equipos.RowTemplate.Height = 24;
            this.dgv_equipos.Size = new System.Drawing.Size(637, 368);
            this.dgv_equipos.TabIndex = 87;
            this.dgv_equipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_equipos_CellDoubleClick);
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 972);
            this.Controls.Add(this.dgv_equipos);
            this.Controls.Add(this.cmb_torneo);
            this.Controls.Add(this.lbl_torneo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_encargado);
            this.Controls.Add(this.lbl_encargado);
            this.Controls.Add(this.txt_origen);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_equipo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pnl_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEquipos";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_equipo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.TextBox txt_encargado;
        private System.Windows.Forms.Label lbl_encargado;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.ComboBox cmb_torneo;
        private System.Windows.Forms.Label lbl_torneo;
        private System.Windows.Forms.DataGridView dgv_equipos;
    }
}