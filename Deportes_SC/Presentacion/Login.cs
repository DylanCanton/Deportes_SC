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
using Deportes_SC.Presentacion;

namespace Deportes_SC
{
    public partial class Login : Form
    {
        BDUsuarios usuarios = new BDUsuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*-----------------------------------------------------------------------------*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = txt_usr.Text;
            string contrasenna = txt_psw.Text;

            string rol = usuarios.ValidarUsuario(usuario, contrasenna);

            if (rol != null)
            {
                if (rol == "Administrador")
                {
                    FrmPrincipal menuPrincipal = new FrmPrincipal();
                    MessageBox.Show("Bienvenido, Administrador: " + usuario);
                    menuPrincipal.Show();
                    this.Hide();
                }
                else if (rol == "SubAdministrador")
                {
                    MessageBox.Show("Bienvenido, SubAdministrador: " + usuario);
                    MenuSubAdmin menuSubAdmin = new MenuSubAdmin();
                    menuSubAdmin.Show();
                    this.Hide();
                }
                else if (rol == "Arbitro")
                {
                    MessageBox.Show("Bienvenido, Arbitro: " + usuario);
                    FrmPartidos frmPartidos = new FrmPartidos();
                    frmPartidos.Show();
                    this.Hide();
                }
            }
            else
            {
                // Ningun usuario valido
                MessageBox.Show("Usuario o contraseña inválidos. Intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
