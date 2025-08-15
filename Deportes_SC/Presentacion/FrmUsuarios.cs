using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportes_SC.Datos;
using Deportes_SC.Objetos;

namespace Deportes_SC.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        BDUsuarios usuarios = new BDUsuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.Id = int.Parse(txt_id.Text);
            usr.Nusuario = txt_usr.Text;
            usr.Contrasenna = txt_psw.Text;
            usr.Estado = cmb_estado.SelectedIndex;
            usr.Rol = cmb_tipo.Text;

            usuarios.guardarUsuarioSQL(usr);
            MessageBox.Show("Registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
