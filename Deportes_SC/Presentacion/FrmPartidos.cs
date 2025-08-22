using Deportes_SC.Datos;
using Deportes_SC.Objetos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Deportes_SC.Presentacion
{
    public partial class FrmPartidos : Form
    {
        private readonly BDTorneos torneos = new BDTorneos();
        private readonly BDPartidos partidos = new BDPartidos();

        // Partido/Equipos seleccionados
        int idPartidoSel, idEquipoCasaSel, idEquipoVisitaSel;
        string nombreCasaSel, nombreVisitaSel;

        // Contadores en UI (no tocan BD hasta finalizar)
        int golesCasaUI, golesVisitaUI;

        // Data para combos
        DataTable dtJugCasa, dtJugVisita;

        public FrmPartidos()
        {
            InitializeComponent();
            CargarTorneos();
            CargarPartidosDelTorneo();
        }

        // ==== Navegación ====
        private void volver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void volver_Click_1(object sender, EventArgs e) => volver_Click(sender, e);

        // ==== Torneos / Partidos ====
        private void CargarTorneos()
        {
            try
            {
                var lista = torneos.mostrarTorneosSQL();

                cmbTorneo.SelectedIndexChanged -= cmbTorneo_SelectedIndexChanged;
                cmbTorneo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTorneo.DisplayMember = "Nombre";
                cmbTorneo.ValueMember = "Identificador";
                cmbTorneo.DataSource = lista;
                cmbTorneo.SelectedIndexChanged += cmbTorneo_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando torneos: " + ex.Message);
            }
        }

        private int? ObtenerIdTorneoSeleccionado()
        {
            if (cmbTorneo.SelectedValue == null) return null;
            if (cmbTorneo.SelectedValue is int id) return id;
            if (cmbTorneo.SelectedValue is string s && int.TryParse(s, out var idStr)) return idStr;
            if (cmbTorneo.SelectedItem is Torneo t) return t.Identificador;
            return null;
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e) => CargarPartidosDelTorneo();
        private void btnRefrescar_Click(object sender, EventArgs e) => CargarPartidosDelTorneo();

        private void CargarPartidosDelTorneo()
        {
            var idOpt = ObtenerIdTorneoSeleccionado();
            if (idOpt == null) return;

            int idTorneo = idOpt.Value;

            // Esta llamada retorna List<Partido>
            var lista = partidos.MostrarPartidosPorTorneoSQL(idTorneo);
            dgvPartidos.AutoGenerateColumns = true;
            dgvPartidos.DataSource = lista;

            // Ocultar columnas técnicas
            OcultarColumna("Identificador");
            OcultarColumna("Torneo");
            OcultarColumna("EquipoCasa");
            OcultarColumna("EquipoVisita");

            // Etiquetas amigables (si existen)
            RenombrarColumna("NombreEquipoCasa", "Casa");
            RenombrarColumna("NombreEquipoVisita", "Visita");
            RenombrarColumna("GolesCasa", "G. Casa");
            RenombrarColumna("GolesVisita", "G. Visita");
            // (opcional) RenombrarColumna("Estado", "Estado");
            // (opcional) RenombrarColumna("Fase", "Fase");

            // Limpiar encabezado/labels
            lblPartidoSel.Text = "Partido seleccionado: (ninguno)";
            lblEquipoCasa.Text = "Casa (0)";
            lblEquipoVisita.Text = "Visita (0)";
            idPartidoSel = idEquipoCasaSel = idEquipoVisitaSel = 0;
            nombreCasaSel = nombreVisitaSel = "";
            golesCasaUI = golesVisitaUI = 0;
        }

        private void OcultarColumna(string name)
        {
            if (dgvPartidos.Columns[name] != null)
                dgvPartidos.Columns[name].Visible = false;
        }
        private void RenombrarColumna(string name, string header)
        {
            if (dgvPartidos.Columns[name] != null)
                dgvPartidos.Columns[name].HeaderText = header;
        }

        // ==== Doble clic: cargar partido y marcador real desde BD ====
        private void dgvPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // DataSource: List<Partido> -> usamos el objeto directamente
            var item = dgvPartidos.Rows[e.RowIndex].DataBoundItem as Partido;
            if (item == null) { MessageBox.Show("No se pudo leer el origen de datos."); return; }

            idPartidoSel = item.Identificador;
            idEquipoCasaSel = item.EquipoCasa;
            idEquipoVisitaSel = item.EquipoVisita;
            nombreCasaSel = item.NombreEquipoCasa ?? ("Equipo " + item.EquipoCasa);
            nombreVisitaSel = item.NombreEquipoVisita ?? ("Equipo " + item.EquipoVisita);

            // Marcador REAL de BD (guardado en Partido)
            var m = ObtenerMarcadorYEstadoPartidoSQL(idPartidoSel);
            golesCasaUI = m.gc;
            golesVisitaUI = m.gv;

            // Cargar jugadores para combos
            dtJugCasa = partidos.ListarJugadoresPorEquipoSQL(idEquipoCasaSel);
            dtJugVisita = partidos.ListarJugadoresPorEquipoSQL(idEquipoVisitaSel);

            rbCasa.Checked = true;
            cmb_jugadorCasa.DisplayMember = "nombre";
            cmb_jugadorCasa.ValueMember = "id";
            cmb_jugadorCasa.DataSource = dtJugCasa;

            // Pintar
            PintarMarcador();
            lblPartidoSel.Text = $"  {nombreCasaSel} vs {nombreVisitaSel}";
        }

        // Lee goles y estado de la tabla Partido
        private (int gc, int gv, string estado) ObtenerMarcadorYEstadoPartidoSQL(int idPartido)
        {
            int gc = 0, gv = 0; string est = "PENDIENTE";
            try
            {
                Conexion cx = new Conexion();
                string sql = "SELECT golesCasa, golesVisita, estado FROM Partido WHERE id=@id";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@id", idPartido);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            gc = Convert.ToInt32(r["golesCasa"]);
                            gv = Convert.ToInt32(r["golesVisita"]);
                            est = r["estado"].ToString();
                        }
                    }
                }
                cx.Desconectar();
            }
            catch (Exception ex) { MessageBox.Show("Error leyendo marcador: " + ex.Message); }
            return (gc, gv, est);
        }

        private void PintarMarcador()
        {
            lblEquipoCasa.Text = $"{nombreCasaSel} ({golesCasaUI})";
            lblEquipoVisita.Text = $"{nombreVisitaSel} ({golesVisitaUI})";
        }

        // ==== Agregar sanción (guardar al vuelo; si es GOL, solo labels) ====
        private string MapTipoUiToDb(string txt)
        {
            if (txt == "Gol") return "GOL";
            if (txt == "Tarjeta Amarilla") return "TJA";
            if (txt == "Tarjeta Roja") return "TJR";
            // Si también usas tarjeta azul:
            // if (txt == "Tarjeta Azul") return "TAZ";
            return "";
        }

        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCasa.Checked && dtJugCasa != null)
                cmb_jugadorCasa.DataSource = dtJugCasa;
        }
        private void rbVisita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVisita.Checked && dtJugVisita != null)
                cmb_jugadorCasa.DataSource = dtJugVisita;
        }

        private void btnAgregarSancion_Click(object sender, EventArgs e)
        {
            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }
            if (cmbTipo.SelectedIndex < 0) { MessageBox.Show("Seleccione el tipo."); return; }
            if (cmb_jugadorCasa.SelectedValue == null) { MessageBox.Show("Seleccione un jugador."); return; }

            int idEquipo = rbCasa.Checked ? idEquipoCasaSel : idEquipoVisitaSel;
            int idJugador = Convert.ToInt32(cmb_jugadorCasa.SelectedValue);
            int minuto = (int)nudMinuto1.Value;
            if (minuto < 0 || minuto > 130) { MessageBox.Show("Minuto inválido (0–130)."); return; }

            string tipoDb = MapTipoUiToDb(cmbTipo.Text);
            if (string.IsNullOrEmpty(tipoDb)) { MessageBox.Show("Tipo inválido."); return; }

            // Guardar sanción en BD
            btnAgregarSancion.Enabled = false;
            try
            {
                bool ok = partidos.InsertarSancionSQL(idPartidoSel, idEquipo, idJugador, minuto, tipoDb);
                if (!ok) return;

                // Si fue gol, solo actualizar labels (no tocamos Partido aún)
                if (tipoDb == "GOL")
                {
                    if (idEquipo == idEquipoCasaSel) golesCasaUI++;
                    else golesVisitaUI++;
                    PintarMarcador();
                }

                // UX: avanzar minuto (opcional)
                if (minuto < 130) nudMinuto1.Value = minuto + 1;
            }
            finally
            {
                btnAgregarSancion.Enabled = true;
            }
        }

        // ==== Finalizar: persistir marcador en Partido, estado y refrescar grid ====
        private void btnGuardarResultado_Click(object sender, EventArgs e)
        {
            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }

            btnGuardarResultado.Enabled = false;
            try
            {
                // Persistimos marcador final en Partido
                if (!partidos.ActualizarMarcadorPartidoSQL(idPartidoSel, golesCasaUI, golesVisitaUI))
                {
                    MessageBox.Show("No se pudo guardar el marcador final.");
                    return;
                }

                // Estado FINALIZADO
                if (!partidos.ActualizarEstadoPartidoSQL(idPartidoSel, "FINALIZADO"))
                {
                    MessageBox.Show("No se pudo actualizar el estado del partido.");
                    return;
                }

                // Refrescar lista de partidos del torneo
                var idOpt = ObtenerIdTorneoSeleccionado();
                if (idOpt != null)
                {
                    var lista = partidos.MostrarPartidosPorTorneoSQL(idOpt.Value);
                    dgvPartidos.DataSource = lista;

                    // ocultar columnas técnicas
                    OcultarColumna("Identificador");
                    OcultarColumna("Torneo");
                    OcultarColumna("EquipoCasa");
                    OcultarColumna("EquipoVisita");

                    RenombrarColumna("NombreEquipoCasa", "Casa");
                    RenombrarColumna("NombreEquipoVisita", "Visita");
                    RenombrarColumna("GolesCasa", "G. Casa");
                    RenombrarColumna("GolesVisita", "G. Visita");
                }

                MessageBox.Show("Partido finalizado.");
            }
            finally
            {
                btnGuardarResultado.Enabled = true;
            }
        }
    }
}
