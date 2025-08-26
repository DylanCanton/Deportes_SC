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
    public partial class MenuSubAdmin : Form
    {
        public MenuSubAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.Show();
            this.Hide();
            
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FrmJugadores frmJugadores = new FrmJugadores();
            frmJugadores.Show();
            this.Hide();
        }

        private void btnEmparejamientos_Click(object sender, EventArgs e)
        {
            FrmEmparejamientos frmEmparejamientos = new FrmEmparejamientos();
            frmEmparejamientos.Show();
            this.Hide();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            FrmPartidos frmPartidos = new FrmPartidos();
            frmPartidos.Show(); 
            this.Hide();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show(); 
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
