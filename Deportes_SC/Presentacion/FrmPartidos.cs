using Deportes_SC.Datos;
using Deportes_SC.Objetos;
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
    public partial class FrmPartidos : Form
    {
        BDTorneos torneos = new BDTorneos();
        BDEquipos equipos = new BDEquipos();
        BDPartidos partidos = new BDPartidos();

        Dictionary<int, string> nombresEquipos = new Dictionary<int, string>();
        List<Partido> calendario = new List<Partido>();
        public FrmPartidos()
        {
            InitializeComponent();

        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

        }
    }
}
