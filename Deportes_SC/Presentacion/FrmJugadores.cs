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
            var dt = equipos.ListarEquiposSQL(); 

            cmb_equipo.DisplayMember = "Nombre";  // Se muestra el Nombre
            cmb_equipo.ValueMember = "Id";      // Se agarra el ID por debajo
            cmb_equipo.DataSource = dt;

        }

        private void cargarJugadores()
        {
            var dt = new BDJugadores().ListarJugadoresSQL();
            dgv_jugadores.AutoGenerateColumns = true;
            dgv_jugadores.DataSource = dt;

            // Nombre de columnas
            dgv_jugadores.Columns["Id"].HeaderText = "ID";
            dgv_jugadores.Columns["Cedula"].HeaderText = "Cédula";
            dgv_jugadores.Columns["Nombre"].HeaderText = "Nombre";
            dgv_jugadores.Columns["Posicion"].HeaderText = "Posición";
            dgv_jugadores.Columns["Dorsal"].HeaderText = "Dorsal";
            dgv_jugadores.Columns["NombreEquipo"].HeaderText = "Equipo";

            // Ocultamos las que no queremos mostrar
            if (dgv_jugadores.Columns.Contains("Genero"))
                dgv_jugadores.Columns["Genero"].Visible = false;
            if (dgv_jugadores.Columns.Contains("FechaNacimiento"))
                dgv_jugadores.Columns["FechaNacimiento"].Visible = false;
            if (dgv_jugadores.Columns.Contains("IdEquipo"))
                dgv_jugadores.Columns["IdEquipo"].Visible = false;
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
            jugador.Dorsal = int.Parse(txt_dorsal.Text);
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
            jugador.Dorsal = int.Parse(txt_dorsal.Text);
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
            if (e.RowIndex < 0) return;

            var fila = dgv_jugadores.Rows[e.RowIndex];

            // Campos visibles
            txt_id.Text = fila.Cells["Id"].Value?.ToString();
            txt_cedula.Text = fila.Cells["Cedula"].Value?.ToString();
            txt_nombre.Text = fila.Cells["Nombre"].Value?.ToString();
            cmb_posicion.Text = fila.Cells["Posicion"].Value?.ToString();
            txt_dorsal.Text = fila.Cells["Dorsal"].Value?.ToString();

            // Campos ocultos para edición
            cmb_genero.Text = fila.Cells["Genero"].Value?.ToString();

            if (fila.Cells["FechaNacimiento"].Value != DBNull.Value)
                dtp_fechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);

            // Combo de equipo por Id
            if (fila.Cells["IdEquipo"].Value != DBNull.Value)
                cmb_equipo.SelectedValue = Convert.ToInt32(fila.Cells["IdEquipo"].Value);
        }
    }
}
