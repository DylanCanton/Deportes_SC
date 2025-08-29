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
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
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
            string faseActual = string.IsNullOrEmpty(partidosGenerados.First().Fase) ? "REGULAR" : partidosGenerados.First().Fase;

            btnRegistrar.Enabled = false;
            btnGenerarFase.Enabled = false;
            btnGenerarFinal.Enabled = false;
            try
            {
                // Borrar SOLO la fase que se registra
                if (!bdPartidos.EliminarFase(idTorneo, faseActual))
                {
                    MessageBox.Show($"No se pudo limpiar la fase previa: {faseActual}");
                    return;
                }

                bool ok = bdPartidos.GuardarLista(partidosGenerados);
                MessageBox.Show(ok
                    ? $"Emparejamientos de {faseActual} guardados correctamente."
                    : "Ocurrió un error al guardar los emparejamientos.");
            }
            finally
            {
                btnRegistrar.Enabled = true;
                btnGenerarFase.Enabled = true;
                btnGenerarFinal.Enabled = true;
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void dgvEmparejamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnFasefinal_Click(object sender, EventArgs e)
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

        private void AjustarColumnas()
        {
            // Mostrar nombres si están
            if (dgvEmparejamientos.Columns["NombreEquipoCasa"] != null)
                dgvEmparejamientos.Columns["NombreEquipoCasa"].HeaderText = "Casa";
            if (dgvEmparejamientos.Columns["NombreEquipoVisita"] != null)
                dgvEmparejamientos.Columns["NombreEquipoVisita"].HeaderText = "Visita";

            // Ocultar campos internos
            string[] ocultar = { "Identificador", "FechaHora", "GolesCasa", "GolesVisita", "EquipoCasa", "EquipoVisita" };
            foreach (var c in ocultar)
                if (dgvEmparejamientos.Columns[c] != null)
                    dgvEmparejamientos.Columns[c].Visible = false;

            if (dgvEmparejamientos.Columns["Torneo"] != null)
                dgvEmparejamientos.Columns["Torneo"].HeaderText = "Id Torneo";
            if (dgvEmparejamientos.Columns["Jornada"] != null)
                dgvEmparejamientos.Columns["Jornada"].HeaderText = "Jornada";
            if (dgvEmparejamientos.Columns["Fase"] != null)
                dgvEmparejamientos.Columns["Fase"].HeaderText = "Fase";
            if (dgvEmparejamientos.Columns["Estado"] != null)
                dgvEmparejamientos.Columns["Estado"].HeaderText = "Estado";
        }

        private void btnGenerarFase_Click(object sender, EventArgs e)
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

        private void btnGenerarFinal_Click(object sender, EventArgs e)
        {
            if (cmbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un torneo.");
                return;
            }
            int idTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);

            // Validamos que la fase regular este finalizada
            if (!bdPartidos.FaseTerminada(idTorneo, "REGULAR"))
            {
                MessageBox.Show("Aún hay partidos PENDIENTE en la fase REGULAR.");
                return;
            }

            // Obtenemos el top 4 de los clasificados
            var top4 = bdPartidos.TopKClasificados(idTorneo, 4);
            if (top4 == null || top4.Count < 2)
            {
                MessageBox.Show("No hay suficientes equipos para la FASE FINAL.");
                return;
            }

            // Aca se genera la fase final
            var listaFinal = EmparejamientosGenerador.Generar(idTorneo, top4, false); // false = solo ida
            foreach (var p in listaFinal)
            {
                p.Fase = "FINAL";
                p.Estado = "PENDIENTE";
            }

            // Completar nombres
            var nombres = bdEquipos.DiccionarioNombresPorTorneo(idTorneo);
            foreach (var p in listaFinal)
            {
                if (nombres.TryGetValue(p.EquipoCasa, out var nomC)) p.NombreEquipoCasa = nomC;
                if (nombres.TryGetValue(p.EquipoVisita, out var nomV)) p.NombreEquipoVisita = nomV;
            }

            // mostramos en el grid
            partidosGenerados = listaFinal;
            dgvEmparejamientos.DataSource = null;
            dgvEmparejamientos.DataSource = partidosGenerados;
            AjustarColumnas();

            MessageBox.Show("FASE FINAL generada.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuSubAdmin subAdmin = new MenuSubAdmin();
            subAdmin.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
