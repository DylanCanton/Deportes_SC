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
    public partial class FrmEquipos : Form
    {
        // Sirve para cargar el combobox y elegir un torneo
        BDTorneos torneos = new BDTorneos();
        BDEquipos equipos = new BDEquipos();

        public FrmEquipos()
        {
            InitializeComponent();
            cargarComboTorneos();
            cargarEquipos();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

    /*-----------------------------------------------------------------------------*/
        public void cargarComboTorneos()
        {
            cmb_torneo.DataSource = torneos.mostrarTorneosSQL();
            cmb_torneo.DisplayMember = "Nombre";       // Se mostrará el nombre del torneo
            cmb_torneo.ValueMember = "Identificador";  // Internamente tendrá el ID
        }

        private void cargarEquipos()
        {
            List<Equipo> lista = equipos.mostrarEquiposSQL();
            dgv_equipos.DataSource = null;
            dgv_equipos.DataSource = lista;
        }

        public void limpiar()
        {
            txt_id.Text = "";
            txt_equipo.Text = "";
            txt_origen.Text = "";
            txt_encargado.Text = "";
            txt_telefono.Text = "";
            cmb_torneo.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            Equipo equipo = new Equipo();
            equipo.Identificador = ID;
            equipo.Nombre = txt_equipo.Text;
            equipo.LugarOrigen = txt_origen.Text;
            equipo.Encargado = txt_encargado.Text;
            equipo.Telefono = txt_telefono.Text;
            equipo.Torneo = Convert.ToInt32(cmb_torneo.SelectedValue);

            equipos.guardarEquipoSQL(equipo);
            MessageBox.Show("Agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarEquipos();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
   
            Equipo equipo = new Equipo();
            equipo.Identificador = int.Parse(txt_id.Text);
            equipo.Nombre = txt_equipo.Text;
            equipo.LugarOrigen = txt_origen.Text;
            equipo.Encargado = txt_encargado.Text;
            equipo.Telefono = txt_telefono.Text;
            equipo.Torneo = Convert.ToInt32(cmb_torneo.SelectedValue);
            equipos.modificarEquipoSQL(equipo);
            MessageBox.Show("Modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarEquipos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            equipos.eliminarEquipoSQL(ID);
            MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarEquipos();
        }

        private void dgv_equipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_equipos.Rows[e.RowIndex];

                txt_id.Text = fila.Cells["Identificador"].Value.ToString();
                txt_equipo.Text = fila.Cells["Nombre"].Value.ToString();
                txt_origen.Text = fila.Cells["lugarOrigen"].Value.ToString();
                txt_encargado.Text = fila.Cells["Encargado"].Value.ToString();
                txt_telefono.Text = fila.Cells["Telefono"].Value.ToString();
                cmb_torneo.SelectedValue = fila.Cells["Torneo"].Value;
            }
        }
    }
}
