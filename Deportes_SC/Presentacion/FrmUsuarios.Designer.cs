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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.volver = new System.Windows.Forms.PictureBox();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 761);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(322, 761);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(120, 761);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(196, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
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
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 864);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.PictureBox volver;
    }
}