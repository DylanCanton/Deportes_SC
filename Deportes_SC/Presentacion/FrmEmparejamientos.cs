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
    public partial class FrmEmparejamientos : Form
    {
        private readonly BDTorneos bdTorneos = new BDTorneos();
        private readonly BDEquipos bdEquipos = new BDEquipos();
        private readonly BDPartidos bdPartidos = new BDPartidos();

        // Estado
        private List<Partido> partidosGenerados = new List<Partido>();
        public FrmEmparejamientos()
        {
            this.Text = "Emparejamientos (Ida y Vuelta)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);

            InitializeComponent();
            CargarTorneos();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            var equipoIds = bdEquipos.ListarIdsPorTorneo(idTorneo);

            if (equipoIds == null || equipoIds.Count < 2)
            {
                MessageBox.Show("Se requieren al menos 2 equipos para generar emparejamientos.");
                return;
            }

            // Siempre ida y vuelta
            partidosGenerados = EmparejamientosGenerador.Generar(idTorneo, equipoIds, true);

            dgvEmparejamientos.DataSource = null;
            dgvEmparejamientos.DataSource = partidosGenerados;

            OcultarColumnasNoNecesarias();
        }

        private void CargarTorneos()
        {
            try
            {
                var lista = bdTorneos.mostrarTorneosSQL();
                cmbTorneo.DataSource = lista;
                cmbTorneo.DisplayMember = "Nombre";
                cmbTorneo.ValueMember = "Identificador";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando torneos: " + ex.Message);
            }
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void OcultarColumnasNoNecesarias()
        {
            string[] ocultar = new string[]
            {
                "Identificador","FechaHora","GolesCasa","GolesVisita",
                "NombreEquipoCasa","NombreEquipoVisita"
            };

            foreach (string col in ocultar)
            {
                if (dgvEmparejamientos.Columns[col] != null)
                    dgvEmparejamientos.Columns[col].Visible = false;
            }

            if (dgvEmparejamientos.Columns["Torneo"] != null)
                dgvEmparejamientos.Columns["Torneo"].HeaderText = "Id Torneo";

            if (dgvEmparejamientos.Columns["EquipoCasa"] != null)
                dgvEmparejamientos.Columns["EquipoCasa"].HeaderText = "Casa (Id)";

            if (dgvEmparejamientos.Columns["EquipoVisita"] != null)
                dgvEmparejamientos.Columns["EquipoVisita"].HeaderText = "Visita (Id)";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un torneo.");
                return;
            }
            if (partidosGenerados == null || partidosGenerados.Count == 0)
            {
                MessageBox.Show("Primero generá los emparejamientos.");
                return;
            }

            int idTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);

            // Evitar doble clic durante el guardado
            btnGuardar.Enabled = false;
            btnGenerar.Enabled = false;
            try
            {
                // Limpia partidos previos del torneo para evitar duplicados
                if (!bdPartidos.LimpiarPorTorneo(idTorneo))
                {
                    MessageBox.Show("No se pudieron limpiar partidos anteriores del torneo.");
                    return;
                }

                // Guarda la lista generada
                bool ok = bdPartidos.GuardarLista(partidosGenerados);
                if (ok)
                {
                    MessageBox.Show("Emparejamientos guardados correctamente.");
                    // Opcionalmente, limpiar el grid o volver a generar/recargar
                    // dgvEmparejamientos.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar los emparejamientos.");
                }
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnGenerar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
