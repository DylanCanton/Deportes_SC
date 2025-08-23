using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Deportes_SC.Datos;
using Deportes_SC.Objetos;

namespace Deportes_SC.Presentacion
{
    public partial class FrmEstadisticas : Form
    {
        private readonly BDTorneos torneos = new BDTorneos();
        private readonly BDEstadistica estadistica = new BDEstadistica();

        public FrmEstadisticas()
        {
            InitializeComponent();
            CargarTorneos();

            // Cargar eventos
            cmbTorneo.SelectedIndexChanged += cmbTorneo_SelectedIndexChanged;
            tab_Reportes.SelectedIndexChanged += tab_Reportes_SelectedIndexChanged;
            // Refrescar los tabControl
            RefrescarTab();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        // ------------------------- TOP Posiciones -------------------------//


        // ------------------------ Datos Goleadores ------------------------//

        private void CargarTorneos()
        {
            try
            {
                var lista = torneos.mostrarTorneosSQL();
                cmbTorneo.DisplayMember = "Nombre";
                cmbTorneo.ValueMember = "Identificador";
                cmbTorneo.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando torneos: " + ex.Message);
            }
        }

        private int ObtenerTorneoSeleccionado()
        {
            if (cmbTorneo == null) return 0;

            object val = cmbTorneo.SelectedValue;
            int id;

            if (val is int) return (int)val;

            if (val is string)
            {
                string s = (string)val;
                if (int.TryParse(s, out id)) return id;
            }

            if (cmbTorneo.SelectedItem is Torneo)
            {
                Torneo t = (Torneo)cmbTorneo.SelectedItem;
                return t.Identificador;
            }

            return 0;
        }

        // ------------------------ TOP Goleadores ------------------------//

        private void RefrescarTopGoleadores()
        {
            int idTorneo = ObtenerTorneoSeleccionado(); 
            var dt = estadistica.TopGoleadoresSQL(idTorneo, 10); // Saca top 10

            // Limpiar columnas
            dgvGoleadores.AutoGenerateColumns = true;
            dgvGoleadores.Columns.Clear();

            BindTopGoleadores(dt);
            BindChartTop(dt);
        }

        // Funcion para mejorar el estilo del dgv
        private void BindTopGoleadores(DataTable dt)
        {
            // Agrega columna de posición (medallas)
            if (!dt.Columns.Contains("Pos")) dt.Columns.Add("Pos", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string medalla;
                if (i == 0) medalla = "🥇";
                else if (i == 1) medalla = "🥈";
                else if (i == 2) medalla = "🥉";
                else medalla = (i + 1).ToString();

                dt.Rows[i]["Pos"] = medalla;
            }
            dt.Columns["Pos"].SetOrdinal(0);

            dgvGoleadores.DataSource = dt;

            if (dgvGoleadores.Columns["Pos"] != null) dgvGoleadores.Columns["Pos"].HeaderText = "#";
            if (dgvGoleadores.Columns["Cedula"] != null) dgvGoleadores.Columns["Cedula"].HeaderText = "Cédula";
            if (dgvGoleadores.Columns["Nombre"] != null) dgvGoleadores.Columns["Nombre"].HeaderText = "Jugador";
            if (dgvGoleadores.Columns["NombreEquipo"] != null) dgvGoleadores.Columns["NombreEquipo"].HeaderText = "Equipo";
            if (dgvGoleadores.Columns["Cantidad"] != null) dgvGoleadores.Columns["Cantidad"].HeaderText = "Goles";

            EstilarDgvTop(dgvGoleadores);
        }

        private void EstilarDgvTop(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.Window;
            dgv.BorderStyle = BorderStyle.None;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgv.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 239, 250);
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns["Pos"] != null)
                dgv.Columns["Pos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["Cantidad"] != null)
                dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        // Funcion para mostrar los graficos
        private void BindChartTop(DataTable dt)
        {
            chartTop.Series.Clear();
            chartTop.ChartAreas.Clear();
            chartTop.Legends.Clear();

            ChartArea area = new ChartArea("area");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.Title = "Goles";
            area.AxisY.Title = "";
            chartTop.ChartAreas.Add(area);

            Series s = new Series("Goleadores");
            s.ChartType = SeriesChartType.Bar; // barras horizontales
            s.IsValueShownAsLabel = true;

            foreach (DataRow r in dt.Rows)
            {
                string nombre = Convert.ToString(r["Nombre"]);
                string equipo = Convert.ToString(r["NombreEquipo"]);
                string label = nombre + " (" + equipo + ")";

                int goles = Convert.ToInt32(r["Cantidad"]);
                int idx = s.Points.AddXY(label, goles); // categoría, valor
                s.Points[idx].ToolTip = label + ": " + goles;
            }

            chartTop.Series.Add(s);
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarTab();
        }

        private void tab_Reportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarTab();
        }

        // Funcion para refrescar a la hora de cambiar de tab
        private void RefrescarTab()
        {
            
            if (tab_Reportes.SelectedTab == tab_Goleadores)
            {
                RefrescarTopGoleadores();
                return;
            }
            if (tab_Reportes.SelectedTab == tab_Equipos)
            {
                // Refrescar Tabla de posiciones;
                return;
            }
            if (tab_Reportes.SelectedTab == tab_Sanciones)
            {
                // Refrescar Tabla de Sanciones;
                return;
            }
            RefrescarTopGoleadores();
        }

        // ------------------------- TOP Sanciones -------------------------//
    }
}
