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
            this.volver = new System.Windows.Forms.PictureBox();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_CategoriaGenero = new System.Windows.Forms.Label();
            this.txt_catEtaria = new System.Windows.Forms.TextBox();
            this.lbl_categoriaEtaria = new System.Windows.Forms.Label();
            this.txt_torneo = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_torneo = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_catGenero = new System.Windows.Forms.ComboBox();
            this.dtp_año = new System.Windows.Forms.DateTimePicker();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_torneos = new System.Windows.Forms.DataGridView();
            this.pic_fondo = new System.Windows.Forms.PictureBox();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_torneos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_superior.Controls.Add(this.volver);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(1000, 44);
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
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_año.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_año.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_año.Location = new System.Drawing.Point(27, 507);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(189, 21);
            this.lbl_año.TabIndex = 66;
            this.lbl_año.Text = "Fecha de realizacion:";
            this.lbl_año.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CategoriaGenero
            // 
            this.lbl_CategoriaGenero.AutoSize = true;
            this.lbl_CategoriaGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CategoriaGenero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CategoriaGenero.Location = new System.Drawing.Point(27, 406);
            this.lbl_CategoriaGenero.Name = "lbl_CategoriaGenero";
            this.lbl_CategoriaGenero.Size = new System.Drawing.Size(189, 21);
            this.lbl_CategoriaGenero.TabIndex = 65;
            this.lbl_CategoriaGenero.Text = "Categoria de genero:";
            this.lbl_CategoriaGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_catEtaria
            // 
            this.txt_catEtaria.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_catEtaria.Location = new System.Drawing.Point(14, 340);
            this.txt_catEtaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_catEtaria.Name = "txt_catEtaria";
            this.txt_catEtaria.Size = new System.Drawing.Size(223, 28);
            this.txt_catEtaria.TabIndex = 64;
            // 
            // lbl_categoriaEtaria
            // 
            this.lbl_categoriaEtaria.AutoSize = true;
            this.lbl_categoriaEtaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_categoriaEtaria.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoriaEtaria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_categoriaEtaria.Location = new System.Drawing.Point(43, 307);
            this.lbl_categoriaEtaria.Name = "lbl_categoriaEtaria";
            this.lbl_categoriaEtaria.Size = new System.Drawing.Size(152, 21);
            this.lbl_categoriaEtaria.TabIndex = 63;
            this.lbl_categoriaEtaria.Text = "Categoria Etaria:";
            this.lbl_categoriaEtaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_torneo
            // 
            this.txt_torneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_torneo.Location = new System.Drawing.Point(14, 237);
            this.txt_torneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_torneo.Name = "txt_torneo";
            this.txt_torneo.Size = new System.Drawing.Size(223, 28);
            this.txt_torneo.TabIndex = 62;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(14, 115);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 28);
            this.txt_id.TabIndex = 61;
            // 
            // lbl_torneo
            // 
            this.lbl_torneo.AutoSize = true;
            this.lbl_torneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_torneo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_torneo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_torneo.Location = new System.Drawing.Point(43, 187);
            this.lbl_torneo.Name = "lbl_torneo";
            this.lbl_torneo.Size = new System.Drawing.Size(172, 21);
            this.lbl_torneo.TabIndex = 60;
            this.lbl_torneo.Text = "Nombre de torneo:";
            this.lbl_torneo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Location = new System.Drawing.Point(60, 80);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(135, 21);
            this.lbl_id.TabIndex = 59;
            this.lbl_id.Text = "Identificacion:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_catGenero
            // 
            this.cmb_catGenero.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_catGenero.FormattingEnabled = true;
            this.cmb_catGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_catGenero.Location = new System.Drawing.Point(14, 439);
            this.cmb_catGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_catGenero.Name = "cmb_catGenero";
            this.cmb_catGenero.Size = new System.Drawing.Size(223, 29);
            this.cmb_catGenero.TabIndex = 67;
            // 
            // dtp_año
            // 
            this.dtp_año.Location = new System.Drawing.Point(3, 540);
            this.dtp_año.Name = "dtp_año";
            this.dtp_año.Size = new System.Drawing.Size(258, 22);
            this.dtp_año.TabIndex = 68;
            this.dtp_año.Value = new System.DateTime(2025, 8, 7, 0, 0, 0, 0);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(822, 540);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 83);
            this.btn_eliminar.TabIndex = 71;
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
            this.btn_modificar.Location = new System.Drawing.Point(640, 540);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(166, 83);
            this.btn_modificar.TabIndex = 70;
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
            this.btn_guardar.Location = new System.Drawing.Point(457, 540);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(166, 83);
            this.btn_guardar.TabIndex = 69;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_torneos
            // 
            this.dgv_torneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_torneos.Location = new System.Drawing.Point(258, 68);
            this.dgv_torneos.Name = "dgv_torneos";
            this.dgv_torneos.RowHeadersWidth = 51;
            this.dgv_torneos.RowTemplate.Height = 24;
            this.dgv_torneos.Size = new System.Drawing.Size(730, 449);
            this.dgv_torneos.TabIndex = 72;
            this.dgv_torneos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_torneos_CellDoubleClick);
            // 
            // pic_fondo
            // 
            this.pic_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_fondo.Image = ((System.Drawing.Image)(resources.GetObject("pic_fondo.Image")));
            this.pic_fondo.Location = new System.Drawing.Point(0, 0);
            this.pic_fondo.Name = "pic_fondo";
            this.pic_fondo.Size = new System.Drawing.Size(1000, 900);
            this.pic_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fondo.TabIndex = 73;
            this.pic_fondo.TabStop = false;
            // 
            // FrmTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.dgv_torneos);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dtp_año);
            this.Controls.Add(this.cmb_catGenero);
            this.Controls.Add(this.lbl_año);
            this.Controls.Add(this.lbl_CategoriaGenero);
            this.Controls.Add(this.txt_catEtaria);
            this.Controls.Add(this.lbl_categoriaEtaria);
            this.Controls.Add(this.txt_torneo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_torneo);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.pic_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTorneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTorneos";
            this.pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_torneos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.Label lbl_CategoriaGenero;
        private System.Windows.Forms.TextBox txt_catEtaria;
        private System.Windows.Forms.Label lbl_categoriaEtaria;
        private System.Windows.Forms.TextBox txt_torneo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_torneo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_catGenero;
        private System.Windows.Forms.DateTimePicker dtp_año;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_torneos;
        private System.Windows.Forms.PictureBox pic_fondo;
    }
}