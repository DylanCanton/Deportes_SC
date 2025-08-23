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

        // Declaracion de variables
        int idPartidoSel, idEquipoCasaSel, idEquipoVisitaSel;
        string nombreCasaSel, nombreVisitaSel;

        // Variables para llenar los label
        int golesCasaUI, golesVisitaUI;

        // Data para combos
        DataTable dtJugCasa, dtJugVisita;

        // Variable para validacion
        bool partidoFinalizado;
        public FrmPartidos()
        {
            InitializeComponent();
            CargarTorneos();
        }

        private void volver_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

    //----------------------------- Funciones -----------------------------------//

        //Funciones para el funcionamiento

        // Se cargan los torneos en el combobox
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

        // Funcion para obtener el torneo que se seleccione en el combobox
        private int ObtenerTorneoSeleccionado()
        {
            if (cmbTorneo.SelectedValue is int id) return id;

            if (cmbTorneo.SelectedValue is string s && int.TryParse(s, out var idStr))
                return idStr;

            if (cmbTorneo.SelectedItem is Torneo t)
                return t.Identificador;

            return 0; // En caso de que no se seleccione nada
        }

        // Funcion para filtrar la fase 
        private string ObtenerFaseSeleccionada()
        {
            if (cmbFases.SelectedIndex < 0 || cmbFases.SelectedItem == null) return null;
            var txt = cmbFases.SelectedItem.ToString().Trim().ToUpperInvariant();
            if (txt == "REGULAR" || txt == "FINAL") return txt;
            return null;
        }

        // Cargar los partidos en el dgv
        private void CargarPartidosDelTorneo()
        {
            partidoFinalizado = false;
            SetEdicionHabilitada(false);
            int idTorneo = ObtenerTorneoSeleccionado();
            if (idTorneo == 0) return;

            string fase = ObtenerFaseSeleccionada(); // Regular o Final

            // Esta lista devuelve los partidos filtrandolos por Torneo y Fase seleccionada
            var lista = partidos.MostrarPartidosPorTorneoSQL(idTorneo, fase);
            dgvPartidos.AutoGenerateColumns = true;
            dgvPartidos.DataSource = lista;

            // Ocultar columnas
            OcultarColumna("Identificador");
            OcultarColumna("Torneo");
            OcultarColumna("EquipoCasa");
            OcultarColumna("EquipoVisita");

            // Mostrar columnas mas entendibles
            RenombrarColumna("NombreEquipoCasa", "Casa");
            RenombrarColumna("NombreEquipoVisita", "Visita");
            RenombrarColumna("GolesCasa", "G. Casa");
            RenombrarColumna("GolesVisita", "G. Visita");

            // Limpiar lbl
            lblPartidoSel.Text = "Partido seleccionado: (ninguno)";
            lblEquipoCasa.Text = "Casa (0)";
            lblEquipoVisita.Text = "Visita (0)";
            idPartidoSel = idEquipoCasaSel = idEquipoVisitaSel = 0;
            nombreCasaSel = nombreVisitaSel = "";
            golesCasaUI = golesVisitaUI = 0;
        }

        // Funcion para cargar la Sancion a la base de datos
        private string ConvertirBD(string txt)
        {
            if (txt == "Gol") return "GOL";
            if (txt == "Tarjeta Amarilla") return "TJA";
            if (txt == "Tarjeta Roja") return "TJR";
            return "";
        }

        // Validacion por si el partido se encuentra "Finalizado"
        private void SetEdicionHabilitada(bool enabled)
        {
            // Controles que no deben usarse si está finalizado
            btnAgregarSancion.Enabled = enabled;
            btnGuardarResultado.Enabled = enabled;
            rbCasa.Enabled = enabled;
            rbVisita.Enabled = enabled;
            cmb_jugador.Enabled = enabled;
            cmbTipo.Enabled = enabled;
            nudMinuto1.Enabled = enabled;
        }

        // Funcion para el marcador
        private void PintarMarcador()
        {
            lblEquipoCasa.Text = $"{nombreCasaSel} ({golesCasaUI})";
            lblEquipoVisita.Text = $"{nombreVisitaSel} ({golesVisitaUI})";
        }

        // Funciones esteticas
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

        //----------------------------- Acciones -----------------------------------//

        private void dgvPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvPartidos.Rows[e.RowIndex].DataBoundItem as Partido;
            if (item == null) { MessageBox.Show("No se pudo leer el origen de datos."); return; }

            idPartidoSel = item.Identificador;
            idEquipoCasaSel = item.EquipoCasa;
            idEquipoVisitaSel = item.EquipoVisita;
            nombreCasaSel = item.NombreEquipoCasa ?? ("Equipo " + item.EquipoCasa);
            nombreVisitaSel = item.NombreEquipoVisita ?? ("Equipo " + item.EquipoVisita);

            // Marcador 
            var marcador = ObtenerMarcadorYEstadoPartidoSQL(idPartidoSel);
            golesCasaUI = marcador.golesCasa;
            golesVisitaUI = marcador.golesVisita;

            // Validacion para no poder editar un partido "Finalizado"
            partidoFinalizado = string.Equals(marcador.estado, "FINALIZADO", StringComparison.OrdinalIgnoreCase);
            SetEdicionHabilitada(!partidoFinalizado);

            // Cargar jugadores para combos
            dtJugCasa = partidos.ListarJugadoresPorEquipoSQL(idEquipoCasaSel);
            dtJugVisita = partidos.ListarJugadoresPorEquipoSQL(idEquipoVisitaSel);

            rbCasa.Checked = true;
            cmb_jugador.DisplayMember = "nombre";
            cmb_jugador.ValueMember = "id";
            cmb_jugador.DataSource = dtJugCasa;

            // Mostrar el marcador
            PintarMarcador();
            lblPartidoSel.Text = $"  {nombreCasaSel} vs {nombreVisitaSel}";
        }


        // Lee goles y estado de la tabla Partido
        private (int golesCasa, int golesVisita, string estado) ObtenerMarcadorYEstadoPartidoSQL(int idPartido)
        {
            int golesCasa = 0, golesVisita = 0; string estado = "PENDIENTE";
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
                            golesCasa = Convert.ToInt32(r["golesCasa"]);
                            golesVisita = Convert.ToInt32(r["golesVisita"]);
                            estado = r["estado"].ToString();
                        }
                    }
                }
                cx.Desconectar();
            }
            catch (Exception ex) { MessageBox.Show("Error leyendo marcador: " + ex.Message); }
            return (golesCasa, golesVisita, estado);
        }

        private void btnAgregarSancion_Click(object sender, EventArgs e)
        {
            // Comprobamos si el partido esta finalizado
            if (partidoFinalizado)
            {
                MessageBox.Show("Este partido ya está FINALIZADO. No se pueden agregar sanciones.");
                return;
            }

            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }
            if (cmbTipo.SelectedIndex < 0) { MessageBox.Show("Seleccione el tipo."); return; }
            if (cmb_jugador.SelectedValue == null) { MessageBox.Show("Seleccione un jugador."); return; }

            int idEquipo = rbCasa.Checked ? idEquipoCasaSel : idEquipoVisitaSel;
            int idJugador = Convert.ToInt32(cmb_jugador.SelectedValue);
            int minuto = (int)nudMinuto1.Value;
            if (minuto < 0 || minuto > 130) { MessageBox.Show("Minuto inválido (0–130)."); return; }

            // Guardamos en BD
            string tipoDb = ConvertirBD(cmbTipo.Text);
            if (string.IsNullOrEmpty(tipoDb)) { MessageBox.Show("Tipo inválido."); return; }

            btnAgregarSancion.Enabled = false;
            try
            {
                bool ok = partidos.InsertarSancionSQL(idPartidoSel, idEquipo, idJugador, minuto, tipoDb);
                if (!ok) return;

                if (tipoDb == "GOL")
                {
                    if (idEquipo == idEquipoCasaSel) golesCasaUI++;
                    else golesVisitaUI++;
                    PintarMarcador();
                }

                // Siguiente minuto
                if (minuto < 130) nudMinuto1.Value = minuto + 1;
            }
            finally
            {
                btnAgregarSancion.Enabled = true;
            }
        }

        // Cargamos todo y finaliza el partido
        private void btnGuardarResultado_Click(object sender, EventArgs e)
        {
            if (partidoFinalizado)
            {
                MessageBox.Show("Partido finalizado, no se puede modificar");
                return;
            }

            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }

            btnGuardarResultado.Enabled = false;
            try
                //Actualizamos el marcador
            {
                if (!partidos.ActualizarMarcadorPartidoSQL(idPartidoSel, golesCasaUI, golesVisitaUI))
                {
                    MessageBox.Show("No se pudo guardar el marcador final.");
                    return;
                }
                // Actualizamos el estado
                if (!partidos.ActualizarEstadoPartidoSQL(idPartidoSel, "FINALIZADO"))
                {
                    MessageBox.Show("No se pudo actualizar el estado del partido.");
                    return;
                }

                // Luego de finalizar, bloqueamos la edicion del partido
                partidoFinalizado = true;
                SetEdicionHabilitada(false);

                // Refrescar grid con el mismo filtro
                int idTorneo = ObtenerTorneoSeleccionado();
                if (idTorneo != 0)
                {
                    string fase = ObtenerFaseSeleccionada();
                    var lista = partidos.MostrarPartidosPorTorneoSQL(idTorneo, fase);
                    dgvPartidos.DataSource = lista;

                    // Ocultar columnas tecnias
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


        private void cmbFases_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPartidosDelTorneo();
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPartidosDelTorneo();
        }

        // Cambia de jugadores de acuerdo al equipo que se selecciono en el rd
        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCasa.Checked && dtJugCasa != null)
                cmb_jugador.DataSource = dtJugCasa;
        }
        private void rbVisita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVisita.Checked && dtJugVisita != null)
                cmb_jugador.DataSource = dtJugVisita;
        }
    }
}
