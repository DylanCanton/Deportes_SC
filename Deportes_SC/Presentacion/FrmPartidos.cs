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
        private readonly BDTorneos bdTorneos = new BDTorneos();
        private readonly BDPartidos bdPartidos = new BDPartidos();

        private Partido partidoSeleccionado = null;
        public FrmPartidos()
        {
            InitializeComponent(); // si usaste diseñador
            this.Text = "Partidos (Árbitro)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1000, 640);

            CargarTorneos();

        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        //---------------------------------------------------------------//

        private void CargarTorneos()
        {
            try
            {
                var lista = bdTorneos.mostrarTorneosSQL(); // List<Torneo> con props: Identificador, Nombre

                // temporalmente quitar el handler para que no se dispare durante el binding
                cmbTorneo.SelectedIndexChanged -= cmbTorneo_SelectedIndexChanged;

                cmbTorneo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTorneo.DisplayMember = "Nombre";
                cmbTorneo.ValueMember = "Identificador";  // <- MUY IMPORTANTE
                cmbTorneo.DataSource = lista;

                // re-enganchar el handler
                cmbTorneo.SelectedIndexChanged += cmbTorneo_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando torneos: " + ex.Message);
            }
        }

        private void LimpiarEditor()
        {
            partidoSeleccionado = null;
            lblPartidoSel.Text = "Partido seleccionado: (ninguno)";
            nudGolesCasa.Value = 0;
            nudGolesVisita.Value = 0;
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPartidosDelTorneo();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarPartidosDelTorneo();
        }

        private void dgvPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarPartidoSeleccionadoDesdeGrid();
        }

        private int? ObtenerIdTorneoSeleccionado()
        {
            if (cmbTorneo.SelectedValue == null) return null;

            // Caso ideal: ValueMember aplicado
            if (cmbTorneo.SelectedValue is int id) return id;

            // A veces viene como string
            if (cmbTorneo.SelectedValue is string s && int.TryParse(s, out var idStr)) return idStr;

            // Si ValueMember no aplicó, usa el objeto seleccionado
            if (cmbTorneo.SelectedItem is Torneo t) return t.Identificador;

            return null;
        }
        private void CargarPartidosDelTorneo()
        {
            var idOpt = ObtenerIdTorneoSeleccionado();
            if (idOpt == null) return;

            int idTorneo = idOpt.Value;

            dgvPartidos.DataSource = bdPartidos.MostrarPartidosPorTorneoSQL(idTorneo);

            // Renombrar cabeceras útiles
            if (dgvPartidos.Columns["Jornada"] != null) dgvPartidos.Columns["Jornada"].HeaderText = "Jornada";
            if (dgvPartidos.Columns["NombreEquipoCasa"] != null) dgvPartidos.Columns["NombreEquipoCasa"].HeaderText = "Casa";
            if (dgvPartidos.Columns["NombreEquipoVisita"] != null) dgvPartidos.Columns["NombreEquipoVisita"].HeaderText = "Visita";
            if (dgvPartidos.Columns["GolesCasa"] != null) dgvPartidos.Columns["GolesCasa"].HeaderText = "G. Casa";
            if (dgvPartidos.Columns["GolesVisita"] != null) dgvPartidos.Columns["GolesVisita"].HeaderText = "G. Visita";

            string[] ocultar = { "Identificador", "Torneo", "FechaHora", "EquipoCasa", "EquipoVisita" };
            foreach (var c in ocultar)
                if (dgvPartidos.Columns[c] != null) dgvPartidos.Columns[c].Visible = false;

            LimpiarEditor();
        }

        private void CargarPartidoSeleccionadoDesdeGrid()
        {
            if (dgvPartidos.CurrentRow == null) return;

            var item = dgvPartidos.CurrentRow.DataBoundItem as Partido;
            if (item == null) return;

            partidoSeleccionado = item;

            string casa = item.NombreEquipoCasa ?? ("Equipo " + item.EquipoCasa);
            string visita = item.NombreEquipoVisita ?? ("Equipo " + item.EquipoVisita);
            lblPartidoSel.Text = $"Partido seleccionado: Jornada {item.Jornada} — {casa} vs {visita}";

            nudGolesCasa.Value = item.GolesCasa < 0 ? 0 : item.GolesCasa;
            nudGolesVisita.Value = item.GolesVisita < 0 ? 0 : item.GolesVisita;
        }

        private void btnGuardarResultado_Click(object sender, EventArgs e)
        {
            if (partidoSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un partido de la lista.");
                return;
            }

            partidoSeleccionado.GolesCasa = Convert.ToInt32(nudGolesCasa.Value);
            partidoSeleccionado.GolesVisita = Convert.ToInt32(nudGolesVisita.Value);
            partidoSeleccionado.Estado = "Finalizado";

            bool ok = bdPartidos.GuardarPartidoSQL(partidoSeleccionado);
            if (ok)
            {
                MessageBox.Show("Resultado guardado.");
                CargarPartidosDelTorneo();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el resultado.");
            }
        }
    }
}
