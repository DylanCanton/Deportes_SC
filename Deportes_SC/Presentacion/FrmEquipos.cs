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
            var dt = equipos.ListarEquiposSQL();   
            dgv_equipos.AutoGenerateColumns = true;
            dgv_equipos.DataSource = dt;

            // Muestra un texto mas lindo jeje
            if (dgv_equipos.Columns.Contains("Id"))
                dgv_equipos.Columns["Id"].HeaderText = "ID";
            if (dgv_equipos.Columns.Contains("Nombre"))
                dgv_equipos.Columns["Nombre"].HeaderText = "Nombre";
            if (dgv_equipos.Columns.Contains("LugarOrigen"))
                dgv_equipos.Columns["LugarOrigen"].HeaderText = "Lugar de origen";
            if (dgv_equipos.Columns.Contains("NombreTorneo"))
                dgv_equipos.Columns["NombreTorneo"].HeaderText = "Torneo";

            // Ocultar columnas no necesarias de mostrar
            if (dgv_equipos.Columns.Contains("Encargado"))
                dgv_equipos.Columns["Encargado"].Visible = false;
            if (dgv_equipos.Columns.Contains("Telefono"))
                dgv_equipos.Columns["Telefono"].Visible = false;
            if (dgv_equipos.Columns.Contains("IdTorneo"))
                dgv_equipos.Columns["IdTorneo"].Visible = false;
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

        private void dgv_equipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgv_equipos.Rows[e.RowIndex];

            // Visibles 
            txt_id.Text = fila.Cells["Id"].Value?.ToString();
            txt_equipo.Text = fila.Cells["Nombre"].Value?.ToString();
            txt_origen.Text = fila.Cells["LugarOrigen"].Value?.ToString();

            // Ocultos para edición 
            txt_encargado.Text = fila.Cells["Encargado"].Value?.ToString();
            txt_telefono.Text = fila.Cells["Telefono"].Value?.ToString();

            if (fila.Cells["IdTorneo"].Value != null && fila.Cells["IdTorneo"].Value != DBNull.Value)
                cmb_torneo.SelectedValue = Convert.ToInt32(fila.Cells["IdTorneo"].Value);
            else
                cmb_torneo.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion de campos vacios
           if (txt_id.Text == "" || txt_equipo.Text == "" || txt_origen.Text == "" ||
                txt_encargado.Text == "" || txt_telefono.Text == "" ||
                cmb_torneo.SelectedIndex == -1 )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            equipos.eliminarEquipoSQL(ID);
            MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarEquipos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
