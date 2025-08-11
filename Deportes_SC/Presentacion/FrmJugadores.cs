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
    public partial class FrmJugadores : Form
    {

        // Sirve para cargar el combobox y elegir un torneo
        BDEquipos equipos = new BDEquipos();
        BDJugadores jugadores = new BDJugadores();
        public FrmJugadores()
        {
            InitializeComponent();
            cargarComboEquipos();
            cargarJugadores();
            
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

    /*-----------------------------------------------------------------------------*/
        public void cargarComboEquipos()
        {
            cmb_equipo.DataSource = equipos.mostrarEquiposSQL();
            cmb_equipo.DisplayMember = "Nombre";       // Se mostrará el nombre del torneo
            cmb_equipo.ValueMember = "Identificador";  // Internamente tendrá el ID
        }

        private void cargarJugadores()
        {
            List<Jugador> lista = jugadores.mostrarJugadoresSQL();
            dgv_jugadores.DataSource = null;
            dgv_jugadores.DataSource = lista;
        }

        public void limpiar()
        {
            txt_id.Text = "";
            txt_cedula.Text = "";
            txt_nombre.Text = "";
            cmb_genero.Text = "";
            cmb_equipo.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Identificador = int.Parse(txt_id.Text);
            jugador.Cédula = txt_cedula.Text;
            jugador.Nombre = txt_nombre.Text;
            jugador.Genero = cmb_genero.Text;
            jugador.Posicion = cmb_posicion.Text;
            jugador.Equipo = Convert.ToInt32(cmb_equipo.SelectedValue);
            jugador.FechaNacimiento = dtp_fechaNacimiento.Value.Date;

            jugadores.GuardarJugadorSQL(jugador);
            MessageBox.Show("Agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarJugadores();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Identificador = int.Parse(txt_id.Text);
            jugador.Cédula = txt_cedula.Text;
            jugador.Nombre = txt_nombre.Text;
            jugador.Genero = cmb_genero.Text;
            jugador.Posicion = cmb_posicion.Text;
            jugador.Equipo = Convert.ToInt32(cmb_equipo.SelectedValue);
            jugador.FechaNacimiento = dtp_fechaNacimiento.Value.Date;

            jugadores.modificarJugadorSQL(jugador);
            MessageBox.Show("Modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarJugadores();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);

            jugadores.eliminarEquipoSQL(ID);
            MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarJugadores();
        }

        private void dgv_jugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_jugadores.Rows[e.RowIndex];

                txt_id.Text = fila.Cells["Identificador"].Value.ToString();
                txt_cedula.Text = fila.Cells["Cédula"].Value.ToString();
                txt_nombre.Text = fila.Cells["Nombre"].Value.ToString();
                cmb_genero.Text = fila.Cells["Genero"].Value.ToString();
                cmb_posicion.Text = fila.Cells["Posicion"].Value.ToString();
                cmb_equipo.SelectedValue = fila.Cells["Equipo"].Value;
                dtp_fechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            }
        }
    }
}
