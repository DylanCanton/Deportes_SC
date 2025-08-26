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
        string faseActualSel;   // fase que se está mostrando (REGULAR/FINAL/GRAN_FINAL)
        string fasePartidoSel;  // fase del partido seleccionado en el grid

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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //----------------------------- Funciones -----------------------------------//

        private void limpiarSancion()
        {
            cmbTipo.SelectedIndex = -1;   // sin selección
            nudMinuto1.Value = nudMinuto1.Minimum;
        }

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
            if (cmbTorneo.SelectedValue is int) return (int)cmbTorneo.SelectedValue;

            if (cmbTorneo.SelectedValue is string)
            {
                int idOut;
                string s = (string)cmbTorneo.SelectedValue;
                if (int.TryParse(s, out idOut)) return idOut;
            }

            if (cmbTorneo.SelectedItem is Torneo)
            {
                Torneo t = (Torneo)cmbTorneo.SelectedItem;
                return t.Identificador;
            }

            return 0; // En caso de que no se seleccione nada
        }

        // Funcion para filtrar la fase 
        //private string ObtenerFaseSeleccionada()
        //{
        //    if (cmbFases.SelectedIndex < 0 || cmbFases.SelectedItem == null) return null;
        //    string txt = cmbFases.SelectedItem.ToString().Trim().ToUpperInvariant();
        //    if (txt == "REGULAR" || txt == "FINAL") return txt;
        //    return null;
        //}

        //Cargar los partidos en el dgv
        private void CargarPartidosDelTorneo()
        {
            partidoFinalizado = false;
            SetEdicionHabilitada(false);
            int idTorneo = ObtenerTorneoSeleccionado();
            if (idTorneo == 0)
            {
                dgvPartidos.DataSource = null;
                btnGenerarGranFinal.Visible = false;
                return;
            }

            // Determinar fase actual automáticamente
            faseActualSel = DeterminarFaseActual(idTorneo);
            ActualizarBotonGranFinal(idTorneo);

            // Cargar lista según fase (si null, carga todo)
            var lista = partidos.MostrarPartidosPorTorneoSQL(idTorneo, faseActualSel);
            dgvPartidos.AutoGenerateColumns = true;
            dgvPartidos.DataSource = lista;

            // Ocultar columnas técnicas
            OcultarColumna("Identificador");
            OcultarColumna("Torneo");
            OcultarColumna("EquipoCasa");
            OcultarColumna("EquipoVisita");

            RenombrarColumna("NombreEquipoCasa", "Casa");
            RenombrarColumna("NombreEquipoVisita", "Visita");
            RenombrarColumna("GolesCasa", "G. Casa");
            RenombrarColumna("GolesVisita", "G. Visita");

            // Reset UI
            lblPartidoSel.Text = "Partido seleccionado: (ninguno)";
            lblEquipoCasa.Text = "Casa (0)";
            lblEquipoVisita.Text = "Visita (0)";
            idPartidoSel = idEquipoCasaSel = idEquipoVisitaSel = 0;
            nombreCasaSel = nombreVisitaSel = "";
            golesCasaUI = golesVisitaUI = 0;
            fasePartidoSel = null;
        }


        // Validacion por si el partido se encuentra "Finalizado"
        private void SetEdicionHabilitada(bool enabled)
        {
            // Controles que no deben usarse si está finalizado
            btnAgregaSancion.Enabled = enabled;
            btnGuardaResultado.Enabled = enabled;
            rbCasa.Enabled = enabled;
            rbVisita.Enabled = enabled;
            cmb_jugador.Enabled = enabled;
            cmbTipo.Enabled = enabled;
            nudMinuto1.Enabled = enabled;
        }

        // Funcion para el marcador
        private void PintarMarcador()
        {
            lblEquipoCasa.Text = nombreCasaSel + " (" + golesCasaUI + ")";
            lblEquipoVisita.Text = nombreVisitaSel + " (" + golesVisitaUI + ")";
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
            lblPartidoSel.Text = "  " + nombreCasaSel + " vs " + nombreVisitaSel;
            fasePartidoSel = item.Fase?.ToUpperInvariant();
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
            
        }

        private void btnGenerarGranFinal_Click(object sender, EventArgs e)
        {
            if (cmbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un torneo.");
                return;
            }
            int idTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);

            // Debe estar 100% terminada la FASE FINAL
            if (!partidos.FaseTerminada(idTorneo, "FINAL"))
            {
                MessageBox.Show("Aún hay partidos pendientes en la FASE FINAL.");
                return;
            }

            // Evitar duplicado
            if (partidos.ExisteGranFinal(idTorneo))
            {
                MessageBox.Show("Ya existe un partido de GRAN FINAL para este torneo.");
                return;
            }

            // Top-2 de la Fase Final
            var top2 = partidos.TopKClasificadosPorFase(idTorneo, "FINAL", 2);
            if (top2 == null || top2.Count < 2)
            {
                MessageBox.Show("No hay suficientes equipos para la GRAN FINAL.");
                return;
            }

            // Crear partido único
            if (!partidos.GenerarGranFinalSQL(idTorneo, top2[0], top2[1]))
            {
                MessageBox.Show("No se pudo crear el partido de GRAN FINAL.");
                return;
            }

            // Recargar (ahora la fase actual será GRAN_FINAL)
            CargarPartidosDelTorneo();
            MessageBox.Show("Partido de GRAN FINAL creado.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (partidoFinalizado)
            {
                MessageBox.Show("Partido finalizado, no se puede modificar");
                return;
            }

            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }

            // Calcular ganador/empate (solo para mensaje informativo)
            int puntosCasa = 0;
            int puntosVisita = 0;
            string resumen = "";

            if (golesCasaUI > golesVisitaUI)
            {
                puntosCasa = 3;
                puntosVisita = 0;
                resumen = "Ganador: " + nombreCasaSel + " (" + puntosCasa + " pts)";
            }
            else if (golesCasaUI < golesVisitaUI)
            {
                puntosCasa = 0;
                puntosVisita = 3;
                resumen = "Ganador: " + nombreVisitaSel + " (" + puntosVisita + " pts)";
            }
            else
            {
                puntosCasa = 1;
                puntosVisita = 1;
                resumen = "Empate";
            }

            btnGuardaResultado.Enabled = false;
            try
            {
                // 1) Actualizamos el marcador
                if (!partidos.ActualizarMarcadorPartidoSQL(idPartidoSel, golesCasaUI, golesVisitaUI))
                {
                    MessageBox.Show("No se pudo guardar el marcador final.");
                    return;
                }

                // 2) Actualizamos el estado a FINALIZADO (en mayúsculas)
                if (!partidos.ActualizarEstadoPartidoSQL(idPartidoSel, "FINALIZADO"))
                {
                    MessageBox.Show("No se pudo actualizar el estado del partido.");
                    return;
                }

                // 3) Mostrar mensaje de resultado
                string marcadorTxt = nombreCasaSel + " " + golesCasaUI + " - " + golesVisitaUI + " " + nombreVisitaSel;
                MessageBox.Show(
                    "Resultado final\n\n" + marcadorTxt + "\n\n" + resumen,
                    "Final del partido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 4) Si este partido es la GRAN FINAL, anunciar campeón
                if (string.Equals(fasePartidoSel, "GRAN_FINAL", StringComparison.OrdinalIgnoreCase))
                {
                    var (idCampeon, nombre) = partidos.ObtenerCampeonSQL(ObtenerTorneoSeleccionado());
                    if (idCampeon == 0 && nombre == "Empate en Gran Final")
                    {
                        MessageBox.Show("La Gran Final terminó empatada. Definición pendiente (penales).");
                    }
                    else if (idCampeon != 0 && !string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("🏆 CAMPEÓN DEL TORNEO: " + nombre);
                    }
                }

                // 5) Bloquear edición y recargar usando la detección automática de fase
                partidoFinalizado = true;
                SetEdicionHabilitada(false);

                CargarPartidosDelTorneo(); // <- centraliza el refresco según la fase actual del torneo
            }
            finally
            {
                btnGuardaResultado.Enabled = true;
            }
        }

        private void btnAgregaSancion_Click(object sender, EventArgs e)
        {
            // 1) Partido finalizado -> no permitir
            if (partidoFinalizado)
            {
                MessageBox.Show("Este partido ya está FINALIZADO. No se pueden agregar sanciones.");
                return;
            }

            // 2) Validaciones básicas
            if (idPartidoSel == 0) { MessageBox.Show("Seleccione un partido."); return; }
            if (cmbTipo.SelectedIndex < 0) { MessageBox.Show("Seleccione el tipo."); return; }
            if (cmb_jugador.SelectedValue == null) { MessageBox.Show("Seleccione un jugador."); return; }

            int idEquipo = rbCasa.Checked ? idEquipoCasaSel : idEquipoVisitaSel;
            int idJugador = Convert.ToInt32(cmb_jugador.SelectedValue);
            int minuto = (int)nudMinuto1.Value;
            if (minuto < 0 || minuto > 130) { MessageBox.Show("Minuto inválido (0–130)."); return; }

            // 3) Tipo a BD (GOL / TJA / TJR)
            string tipoDb = ConvertirBD(cmbTipo.Text);
            if (string.IsNullOrEmpty(tipoDb))
            {
                MessageBox.Show("Tipo inválido.");
                return;
            }

            // 4) Insertar sanción y reflejar en UI si corresponde
            btnAgregaSancion.Enabled = false;
            try
            {
                bool ok = partidos.InsertarSancionSQL(idPartidoSel, idEquipo, idJugador, minuto, tipoDb);
                if (!ok) return;

                // Si fue GOL, actualizamos el marcador en pantalla
                if (tipoDb == "GOL")
                {
                    if (idEquipo == idEquipoCasaSel) golesCasaUI++;
                    else golesVisitaUI++;
                    PintarMarcador();
                }

                limpiarSancion();

                // Avanzar minuto sugerido
                if (minuto < 130) nudMinuto1.Value = minuto + 1;
            }
            finally
            {
                btnAgregaSancion.Enabled = true;
            }
        }

        // Cargamos todo y finaliza el partido
        private void btnGuardarResultado_Click(object sender, EventArgs e)
        {           
        }

        private void cmbFases_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPartidosDelTorneo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private string DeterminarFaseActual(int idTorneo)
        {
            // 1) ¿Existe GRAN_FINAL?
            if (partidos.ExistenPartidosDelTorneo(idTorneo, "GRAN_FINAL"))
            {
                // Si hay GRAN_FINAL y está pendiente, la fase actual es GRAN_FINAL
                // (o finalizada, igual la mostramos)
                return "GRAN_FINAL";
            }

            // 2) ¿Existe FINAL?
            if (partidos.ExistenPartidosDelTorneo(idTorneo, "FINAL"))
            {
                // Si FINAL tiene pendientes, fase=FINAL
                // Si FINAL terminó, igual mostramos FINAL, y habilitamos el botón para crear GRAN_FINAL
                return "FINAL";
            }

            // 3) Si no hay final, mostrar REGULAR si existe
            if (partidos.ExistenPartidosDelTorneo(idTorneo, "REGULAR"))
                return "REGULAR";

            // 4) Sin partidos aún
            return null;
        }

        private void ActualizarBotonGranFinal(int idTorneo)
        {
            // Visible si existe FINAL, NO existe GRAN_FINAL y FINAL está terminada
            bool existeFinal = partidos.ExistenPartidosDelTorneo(idTorneo, "FINAL");
            bool existeGranFinal = partidos.ExisteGranFinal(idTorneo);
            bool finalTerminada = existeFinal && partidos.FaseTerminada(idTorneo, "FINAL");

            btnGenerarGranFinal.Visible = existeFinal && !existeGranFinal;
            btnGenerarGranFinal.Enabled = existeFinal && !existeGranFinal && finalTerminada;
        }

        private string ConvertirBD(string txt)
        {
            if (txt == "Gol") return "GOL";
            if (txt == "Tarjeta Amarilla") return "TJA";
            if (txt == "Tarjeta Roja") return "TJR";
            return "";
        }

    }
}
