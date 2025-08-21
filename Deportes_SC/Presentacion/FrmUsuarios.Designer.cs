namespace Deportes_SC.Presentacion
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Registrar = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_tipo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Administrador",
            "SubAdministrador",
            "Arbitro"});
            this.cmb_tipo.Location = new System.Drawing.Point(322, 447);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(196, 29);
            this.cmb_tipo.TabIndex = 44;
            // 
            // txt_psw
            // 
            this.txt_psw.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_psw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_psw.Location = new System.Drawing.Point(599, 300);
            this.txt_psw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(196, 28);
            this.txt_psw.TabIndex = 42;
            this.txt_psw.UseSystemPasswordChar = true;
            // 
            // cmb_estado
            // 
            this.cmb_estado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_estado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.cmb_estado.Location = new System.Drawing.Point(307, 300);
            this.cmb_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(196, 29);
            this.cmb_estado.TabIndex = 37;
            // 
            // txt_usr
            // 
            this.txt_usr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_usr.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_usr.Location = new System.Drawing.Point(12, 447);
            this.txt_usr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(196, 28);
            this.txt_usr.TabIndex = 36;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(12, 300);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 28);
            this.txt_id.TabIndex = 35;
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Controls.Add(this.volver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(850, 44);
            this.pnl_superior.TabIndex = 45;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(3, 3);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(60, 38);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volver.TabIndex = 111;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.volver_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 824);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Registrar
            // 
            this.Registrar.Image = ((System.Drawing.Image)(resources.GetObject("Registrar.Image")));
            this.Registrar.Location = new System.Drawing.Point(524, 761);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(196, 76);
            this.Registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Registrar.TabIndex = 47;
            this.Registrar.TabStop = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Location = new System.Drawing.Point(322, 761);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(196, 76);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 48;
            this.Editar.TabStop = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Location = new System.Drawing.Point(120, 761);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(196, 76);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminar.TabIndex = 49;
            this.eliminar.TabStop = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(81, 507);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.RowHeadersWidth = 51;
            this.dgv_Usuarios.RowTemplate.Height = 24;
            this.dgv_Usuarios.Size = new System.Drawing.Size(658, 218);
            this.dgv_Usuarios.TabIndex = 73;
            this.dgv_Usuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuarios_CellDoubleClick);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 864);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDusuarios";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Registrar;
        private System.Windows.Forms.PictureBox Editar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.PictureBox volver;
    }
}