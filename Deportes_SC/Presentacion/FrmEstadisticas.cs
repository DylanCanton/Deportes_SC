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

            // Cargar torneos y setear eventos de una vez
            CargarTorneos();

            cmbTorneo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTorneo.SelectedIndexChanged += cmbTorneo_SelectedIndexChanged;
            tab_Reportes.SelectedIndexChanged += tab_Reportes_SelectedIndexChanged;

            // Forzar selección inicial si hiciera falta
            if (cmbTorneo.Items.Count > 0 && cmbTorneo.SelectedIndex < 0)
                cmbTorneo.SelectedIndex = 0;

            // Carga inicial según tab (por defecto, goleadores)
            RefrescarTab();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Login principal = new Login();
            principal.Show();
            this.Hide();
        }

        // ------------------------ Carga de Torneos ------------------------//

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

            return 0; // 0 => todos los torneos / sin selección
        }

        // ------------------------ TOP Goleadores ------------------------//

        private void RefrescarTopGoleadores()
        {
            int idTorneo = ObtenerTorneoSeleccionado(); // 0 = todos
            var dt = estadistica.TopGoleadoresSQL(idTorneo, 10);

            // limpiar columnas "de diseño" si las hubiera
            dgvGoleadores.AutoGenerateColumns = true;
            dgvGoleadores.Columns.Clear();

            BindTopGoleadores(dt);
        }

        private void BindTopGoleadores(DataTable dt)
        {
            // Agrega columna de posición con medallas
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

        // ------------------------ Tabla de Posiciones ------------------------//

        private void RefrescarTablaPosiciones()
        {
            int idTorneo = ObtenerTorneoSeleccionado();
            if (idTorneo <= 0)
            {
                // Si tienes una opción "Todos", puedes decidir dejar vacío o forzar seleccionar.
                dgvPosiciones.DataSource = null;
                return;
            }

            var dt = estadistica.TablaPosicionesPorTorneoSQL(idTorneo);

            // Agregar columna de posición (medallas) como en goleadores
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

            // Limpiar columnas “de diseñador” y bind
            dgvPosiciones.AutoGenerateColumns = true;
            dgvPosiciones.Columns.Clear();
            dgvPosiciones.DataSource = dt;

            // Encabezados
            if (dgvPosiciones.Columns["Pos"] != null) dgvPosiciones.Columns["Pos"].HeaderText = "#";
            if (dgvPosiciones.Columns["Equipo"] != null) dgvPosiciones.Columns["Equipo"].HeaderText = "Equipo";
            if (dgvPosiciones.Columns["PJ"] != null) dgvPosiciones.Columns["PJ"].HeaderText = "PJ";
            if (dgvPosiciones.Columns["PG"] != null) dgvPosiciones.Columns["PG"].HeaderText = "PG";
            if (dgvPosiciones.Columns["PE"] != null) dgvPosiciones.Columns["PE"].HeaderText = "PE";
            if (dgvPosiciones.Columns["PP"] != null) dgvPosiciones.Columns["PP"].HeaderText = "PP";
            if (dgvPosiciones.Columns["GF"] != null) dgvPosiciones.Columns["GF"].HeaderText = "GF";
            if (dgvPosiciones.Columns["GC"] != null) dgvPosiciones.Columns["GC"].HeaderText = "GC";
            if (dgvPosiciones.Columns["DG"] != null) dgvPosiciones.Columns["DG"].HeaderText = "DG";
            if (dgvPosiciones.Columns["Pts"] != null) dgvPosiciones.Columns["Pts"].HeaderText = "Pts";

            // Ocultar Id técnico si está
            if (dgvPosiciones.Columns["IdEquipo"] != null) dgvPosiciones.Columns["IdEquipo"].Visible = false;

            // Estilos
            EstilarDgvPosiciones(dgvPosiciones);
        }

        private void EstilarDgvPosiciones(DataGridView dgv)
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

            // Alineaciones
            if (dgv.Columns["PJ"] != null) dgv.Columns["PJ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["PG"] != null) dgv.Columns["PG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["PE"] != null) dgv.Columns["PE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["PP"] != null) dgv.Columns["PP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["GF"] != null) dgv.Columns["GF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["GC"] != null) dgv.Columns["GC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["DG"] != null) dgv.Columns["DG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv.Columns["Pts"] != null) dgv.Columns["Pts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // ---------------------------- Top Sanciones --------------------------------//

        // ------------ SANCIONES (nuevo) ------------
        private void RefrescarTopSanciones()
        {
            int idTorneo = ObtenerTorneoSeleccionado();
            // Elige por equipo (puedes cambiar a SancionesPorJugadorSQL si prefieres)
            var dt = estadistica.SancionesPorEquipoSQL(idTorneo);

            dgvSanciones.AutoGenerateColumns = true;
            dgvSanciones.Columns.Clear();

            BindTopSanciones(dt);
        }

        private void BindTopSanciones(DataTable dt)
        {
            // Columna Pos (medallas)
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

            dgvSanciones.DataSource = dt;

            // Renombrar encabezados (por equipo)
            if (dgvSanciones.Columns["Pos"] != null) dgvSanciones.Columns["Pos"].HeaderText = "#";
            if (dgvSanciones.Columns["NombreEquipo"] != null) dgvSanciones.Columns["NombreEquipo"].HeaderText = "Equipo";
            if (dgvSanciones.Columns["Amarillas"] != null) dgvSanciones.Columns["Amarillas"].HeaderText = "T. Amarillas";
            if (dgvSanciones.Columns["Azules"] != null) dgvSanciones.Columns["Azules"].HeaderText = "T. Azules";
            if (dgvSanciones.Columns["Rojas"] != null) dgvSanciones.Columns["Rojas"].HeaderText = "T. Rojas";
            if (dgvSanciones.Columns["Monto"] != null)
            {
                dgvSanciones.Columns["Monto"].HeaderText = "Monto (₡)";
                dgvSanciones.Columns["Monto"].DefaultCellStyle.Format = "N0"; // miles con separador
                dgvSanciones.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            EstilarDgvSanciones(dgvSanciones);
        }

        private void EstilarDgvSanciones(DataGridView dgv)
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

            // Alineaciones numéricas
            string[] cols = { "Amarillas", "Azules", "Rojas" };
            foreach (var c in cols)
                if (dgv.Columns[c] != null)
                    dgv.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgv.Columns["Pos"] != null)
                dgv.Columns["Pos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // ------------------------ Eventos y refresco general ------------------------//

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarTab();
        }

        private void tab_Reportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarTab();
        }

        private void RefrescarTab()
        {
            if (tab_Reportes.SelectedTab == null)
            {
                RefrescarTopGoleadores();
                return;
            }

            if (tab_Reportes.SelectedTab == tab_Goleadores)
            {
                RefrescarTopGoleadores();
                return;
            }

            if (tab_Reportes.SelectedTab == tab_Equipos)
            {
                RefrescarTablaPosiciones();
                return;
            }

            if (tab_Reportes.SelectedTab == tab_Sanciones)
            {
                RefrescarTopSanciones();
                return;
            }

            // Por defecto, carga goleadores
            RefrescarTopGoleadores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
