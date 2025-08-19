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
    public partial class FrmTorneos : Form
    {
        BDTorneos torneos = new BDTorneos();

        public FrmTorneos()
        {
            InitializeComponent();
            cargarTorneos();
           
        }


        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

    /*-----------------------------------------------------------------------------*/

        private void cargarTorneos()
        {
            List<Torneo> lista = torneos.mostrarTorneosSQL(); // Suponiendo que tienes una instancia llamada torneoSQL
            dgv_torneos.DataSource = null;
            dgv_torneos.DataSource = lista;
        }

        public void limpiar()
        {
            txt_id.Text = "";
            txt_torneo.Text = "";
            txt_catEtaria.Text = "";
            cmb_catGenero.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ;
        }

        private void dgv_torneos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_torneos.Rows[e.RowIndex];

                txt_id.Text = fila.Cells["Identificador"].Value.ToString();
                txt_torneo.Text = fila.Cells["Nombre"].Value.ToString();
                txt_catEtaria.Text = fila.Cells["CategoriaEtaria"].Value.ToString();
                cmb_catGenero.Text = fila.Cells["CategoriaGenero"].Value.ToString();
                dtp_año.Value = Convert.ToDateTime(fila.Cells["Año"].Value);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion de campos vacios
            /*if (txt_id.Text == "" || txt_usr.Text == "" || txt_correo.Text == "" ||
                txt_psw.Text == "" || cmb_genero.Text == "" || cmb_tipo.Text == "" ||
                cmb_estado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } */
            Torneo torneo = new Torneo();
            torneo.Identificador = int.Parse(txt_id.Text);
            torneo.Nombre = txt_torneo.Text;
            torneo.CategoriaEtaria = txt_catEtaria.Text;
            torneo.CategoriaGenero = cmb_catGenero.Text;
            torneo.Año = dtp_año.Value;

            torneos.guardarTorneoSQL(torneo); // terminado
            MessageBox.Show("Registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarTorneos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            Torneo torneo = new Torneo();
            torneo.Identificador = int.Parse(txt_id.Text);
            torneo.Nombre = txt_torneo.Text;
            torneo.CategoriaEtaria = txt_catEtaria.Text;
            torneo.CategoriaGenero = cmb_catGenero.Text;
            torneo.Año = dtp_año.Value;

            torneos.modificarTorneoSQL(torneo); // terminado
            MessageBox.Show("Modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarTorneos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            torneos.eliminarTorneoSQL(ID);
            MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            cargarTorneos();
        }
    }
}
