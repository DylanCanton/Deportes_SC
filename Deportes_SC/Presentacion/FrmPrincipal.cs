using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportes_SC.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

    /*-----------------------------------------------------------------------------*/
        // Asignacion de botones para abrir el form que corresponde :)
        private void btn_Torneos_Click(object sender, EventArgs e)
        {
            FrmTorneos frmTorneos = new FrmTorneos();
            frmTorneos.Show();
            this.Hide();
        }

        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.Show();
            this.Hide();
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            FrmJugadores frmJugadores = new FrmJugadores();
            frmJugadores.Show();
            this.Hide();
        }

        private void btn_Partidos_Click(object sender, EventArgs e)
        {
            FrmPartidos frmPartidos = new FrmPartidos();
            frmPartidos.Show();
            this.Hide();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
            this.Hide();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
            this.Hide();
        }

        private void btn_CargarDatos_Click(object sender, EventArgs e)
        {
            //Aqui va el codigo de carga de datos, o sea inserts predeterminados 

        }

        /*-----------------------------------------------------------------------------*/

    }
}
