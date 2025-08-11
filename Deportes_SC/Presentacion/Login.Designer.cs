namespace Deportes_SC
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.Minimized = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pnl_log = new System.Windows.Forms.Panel();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.lbl_Usr = new System.Windows.Forms.Label();
            this.lbl_Psw = new System.Windows.Forms.Label();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.pnl_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_arriba.Controls.Add(this.Minimized);
            this.pnl_arriba.Controls.Add(this.Exit);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(813, 57);
            this.pnl_arriba.TabIndex = 5;
            // 
            // Minimized
            // 
            this.Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.Image = ((System.Drawing.Image)(resources.GetObject("Minimized.Image")));
            this.Minimized.Location = new System.Drawing.Point(743, 12);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(25, 31);
            this.Minimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimized.TabIndex = 11;
            this.Minimized.TabStop = false;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(774, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 31);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 10;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pnl_log
            // 
            this.pnl_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_log.Controls.Add(this.btn_iniciarSesion);
            this.pnl_log.Controls.Add(this.lbl_Usr);
            this.pnl_log.Controls.Add(this.lbl_Psw);
            this.pnl_log.Controls.Add(this.txt_psw);
            this.pnl_log.Controls.Add(this.txt_usr);
            this.pnl_log.Location = new System.Drawing.Point(161, 241);
            this.pnl_log.Name = "pnl_log";
            this.pnl_log.Size = new System.Drawing.Size(491, 329);
            this.pnl_log.TabIndex = 19;
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_iniciarSesion.Location = new System.Drawing.Point(152, 220);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(202, 57);
            this.btn_iniciarSesion.TabIndex = 14;
            this.btn_iniciarSesion.Text = "Iniciar Sesion";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // lbl_Usr
            // 
            this.lbl_Usr.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usr.ForeColor = System.Drawing.Color.White;
            this.lbl_Usr.Location = new System.Drawing.Point(152, 15);
            this.lbl_Usr.Name = "lbl_Usr";
            this.lbl_Usr.Size = new System.Drawing.Size(188, 41);
            this.lbl_Usr.TabIndex = 0;
            this.lbl_Usr.Text = "Usuario";
            this.lbl_Usr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Psw
            // 
            this.lbl_Psw.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Psw.ForeColor = System.Drawing.Color.White;
            this.lbl_Psw.Location = new System.Drawing.Point(152, 101);
            this.lbl_Psw.Name = "lbl_Psw";
            this.lbl_Psw.Size = new System.Drawing.Size(197, 36);
            this.lbl_Psw.TabIndex = 1;
            this.lbl_Psw.Text = "Contraseña";
            this.lbl_Psw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_psw
            // 
            this.txt_psw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_psw.Location = new System.Drawing.Point(152, 153);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(197, 28);
            this.txt_psw.TabIndex = 13;
            this.txt_psw.UseSystemPasswordChar = true;
            // 
            // txt_usr
            // 
            this.txt_usr.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_usr.Location = new System.Drawing.Point(152, 59);
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(197, 28);
            this.txt_usr.TabIndex = 12;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(305, 92);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(320, 143);
            this.lbl_title.TabIndex = 18;
            this.lbl_title.Text = "Asoc. Deportes";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 641);
            this.Controls.Add(this.pnl_log);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.pnl_log.ResumeLayout(false);
            this.pnl_log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.PictureBox Minimized;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel pnl_log;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Label lbl_Usr;
        private System.Windows.Forms.Label lbl_Psw;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

