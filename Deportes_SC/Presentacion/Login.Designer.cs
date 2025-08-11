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
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_arriba.Controls.Add(this.Minimized);
            this.pnl_arriba.Controls.Add(this.Exit);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(781, 57);
            this.pnl_arriba.TabIndex = 5;
            // 
            // Minimized
            // 
            this.Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimized.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.Image = ((System.Drawing.Image)(resources.GetObject("Minimized.Image")));
            this.Minimized.Location = new System.Drawing.Point(711, 12);
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
            this.Exit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(742, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 31);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 10;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txt_psw
            // 
            this.txt_psw.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_psw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_psw.Location = new System.Drawing.Point(258, 557);
            this.txt_psw.Multiline = true;
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(285, 44);
            this.txt_psw.TabIndex = 13;
            this.txt_psw.UseSystemPasswordChar = true;
            // 
            // txt_usr
            // 
            this.txt_usr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_usr.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_usr.Location = new System.Drawing.Point(258, 379);
            this.txt_usr.Multiline = true;
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(285, 44);
            this.txt_usr.TabIndex = 12;
            this.txt_usr.TextChanged += new System.EventHandler(this.txt_usr_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(781, 693);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(514, 676);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(222, 61);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.pnl_arriba);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.PictureBox Minimized;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnRegistrar;
        private System.Windows.Forms.Button button1;
    }
}

