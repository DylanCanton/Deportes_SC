namespace Deportes_SC.Presentacion
{
    partial class FrmTorneos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTorneos));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.txt_catEtaria = new System.Windows.Forms.TextBox();
            this.txt_torneo = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_catGenero = new System.Windows.Forms.ComboBox();
            this.dtp_año = new System.Windows.Forms.DateTimePicker();
            this.dgv_torneos = new System.Windows.Forms.DataGridView();
            this.pic_fondo = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_torneos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(848, 44);
            this.pnl_superior.TabIndex = 46;
            // 
            // txt_catEtaria
            // 
            this.txt_catEtaria.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_catEtaria.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_catEtaria.Location = new System.Drawing.Point(312, 335);
            this.txt_catEtaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_catEtaria.Name = "txt_catEtaria";
            this.txt_catEtaria.Size = new System.Drawing.Size(223, 28);
            this.txt_catEtaria.TabIndex = 64;
            // 
            // txt_torneo
            // 
            this.txt_torneo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_torneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_torneo.Location = new System.Drawing.Point(3, 335);
            this.txt_torneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_torneo.Name = "txt_torneo";
            this.txt_torneo.Size = new System.Drawing.Size(223, 28);
            this.txt_torneo.TabIndex = 62;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(3, 210);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 28);
            this.txt_id.TabIndex = 61;
            // 
            // cmb_catGenero
            // 
            this.cmb_catGenero.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmb_catGenero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_catGenero.FormattingEnabled = true;
            this.cmb_catGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_catGenero.Location = new System.Drawing.Point(312, 215);
            this.cmb_catGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_catGenero.Name = "cmb_catGenero";
            this.cmb_catGenero.Size = new System.Drawing.Size(223, 29);
            this.cmb_catGenero.TabIndex = 67;
            // 
            // dtp_año
            // 
            this.dtp_año.Location = new System.Drawing.Point(587, 217);
            this.dtp_año.Name = "dtp_año";
            this.dtp_año.Size = new System.Drawing.Size(258, 22);
            this.dtp_año.TabIndex = 68;
            this.dtp_año.Value = new System.DateTime(2025, 8, 7, 0, 0, 0, 0);
            // 
            // dgv_torneos
            // 
            this.dgv_torneos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_torneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_torneos.Location = new System.Drawing.Point(40, 421);
            this.dgv_torneos.Name = "dgv_torneos";
            this.dgv_torneos.RowHeadersWidth = 51;
            this.dgv_torneos.RowTemplate.Height = 24;
            this.dgv_torneos.Size = new System.Drawing.Size(730, 309);
            this.dgv_torneos.TabIndex = 72;
            this.dgv_torneos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_torneos_CellDoubleClick);
            // 
            // pic_fondo
            // 
            this.pic_fondo.Image = ((System.Drawing.Image)(resources.GetObject("pic_fondo.Image")));
            this.pic_fondo.Location = new System.Drawing.Point(0, 37);
            this.pic_fondo.Name = "pic_fondo";
            this.pic_fondo.Size = new System.Drawing.Size(845, 829);
            this.pic_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fondo.TabIndex = 73;
            this.pic_fondo.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(124, 783);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 59);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 94;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(326, 783);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(187, 59);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 93;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(519, 783);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(192, 59);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistrar.TabIndex = 92;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 866);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgv_torneos);
            this.Controls.Add(this.dtp_año);
            this.Controls.Add(this.cmb_catGenero);
            this.Controls.Add(this.txt_catEtaria);
            this.Controls.Add(this.txt_torneo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.pic_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTorneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTorneos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_torneos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.TextBox txt_catEtaria;
        private System.Windows.Forms.TextBox txt_torneo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_catGenero;
        private System.Windows.Forms.DateTimePicker dtp_año;
        private System.Windows.Forms.DataGridView dgv_torneos;
        private System.Windows.Forms.PictureBox pic_fondo;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnRegistrar;
    }
}