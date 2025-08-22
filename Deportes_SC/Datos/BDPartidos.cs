using Deportes_SC.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportes_SC.Datos
{
    public class BDPartidos
    {
        // ¿Ya hay partidos de esa Fase para ese Torneo?
        public bool ExistenPartidosDelTorneo(int idTorneo, string fase)
        {
            bool existe = false;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT TOP 1 1 FROM Partido WHERE torneo=@t AND fase=@f";
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                cmd.Parameters.AddWithValue("@t", idTorneo);
                cmd.Parameters.AddWithValue("@f", fase);
                var o = cmd.ExecuteScalar();
                existe = (o != null);
                conex.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar partidos: " + ex.Message);
            }
            return existe;
        }

        public bool GuardarPartidoSQL(Partido p)
        {
            string sql = @"
        UPDATE Partido
        SET golesCasa = @gc,
            golesVisita = @gv,
            estado = @est
        WHERE id = @id";

            try
            {
                Conexion conex = new Conexion();
                using (SqlCommand cmd = new SqlCommand(sql, conex.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@gc", p.GolesCasa);
                    cmd.Parameters.AddWithValue("@gv", p.GolesVisita);
                    cmd.Parameters.AddWithValue("@est", string.IsNullOrEmpty(p.Estado) ? "Finalizado" : p.Estado);
                    cmd.Parameters.AddWithValue("@id", p.Identificador);

                    int cant = cmd.ExecuteNonQuery();
                    conex.Desconectar();
                    return (cant == 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando partido: " + ex.Message);
                return false;
            }
        }


        // Borra todos los partidos de una Fase/Torneo (útil para regenerar calendario)
        public bool EliminarPartidosDelTorneo(int idTorneo, string fase)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM Partido WHERE torneo=@t AND fase=@f";
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                cmd.Parameters.AddWithValue("@t", idTorneo);
                cmd.Parameters.AddWithValue("@f", fase);
                cmd.ExecuteNonQuery();
                conex.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar partidos: " + ex.Message);
                return false;
            }
        }

        public List<Partido> MostrarPartidosPorTorneoSQL(int idTorneo, string fase = null)
        {
            List<Partido> lista = new List<Partido>();
            try
            {
                Conexion conex = new Conexion();
                string sql = @"
        SELECT 
            p.id, p.torneo,
            p.equipoCasa, p.equipoVisita, p.golesCasa, p.golesVisita,
            p.fase, p.estado,
            ec.nombre AS nombreCasa, ev.nombre AS nombreVisita
        FROM Partido p
        JOIN Equipo ec ON ec.id = p.equipoCasa
        JOIN Equipo ev ON ev.id = p.equipoVisita
        WHERE p.torneo = @t
          AND (@f IS NULL OR p.fase = @f)
        ORDER BY p.id";  // <-- Se quitó p.jornada

                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                cmd.Parameters.AddWithValue("@t", idTorneo);
                if (string.IsNullOrEmpty(fase))
                    cmd.Parameters.AddWithValue("@f", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@f", fase);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Partido p = new Partido();
                        p.Identificador = Convert.ToInt32(dr["id"]);
                        p.Torneo = Convert.ToInt32(dr["torneo"]);
                        p.EquipoCasa = Convert.ToInt32(dr["equipoCasa"]);
                        p.EquipoVisita = Convert.ToInt32(dr["equipoVisita"]);
                        p.GolesCasa = Convert.ToInt32(dr["golesCasa"]);
                        p.GolesVisita = Convert.ToInt32(dr["golesVisita"]);
                        p.Fase = dr["fase"].ToString();
                        p.Estado = dr["estado"].ToString();
                        p.NombreEquipoCasa = dr["nombreCasa"].ToString();
                        p.NombreEquipoVisita = dr["nombreVisita"].ToString();
                        lista.Add(p);
                    }
                }
                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error listando partidos: " + e.Message);
            }
            return lista;
        }


        // Pruebas con sanciones y nuevas funciones

        public DataTable ListarJugadoresPorEquipoSQL(int idEquipo)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                string sql = @"SELECT id, nombre, dorsal FROM Jugador WHERE idEquipo=@e ORDER BY nombre;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@e", idEquipo);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex) { MessageBox.Show("Error listando jugadores: " + ex.Message); }
            return dt;
        }

        private bool JugadorPerteneceAlEquipo(int idJugador, int idEquipo)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = "SELECT 1 FROM Jugador WHERE id=@j AND idEquipo=@e";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@j", idJugador);
                    cmd.Parameters.AddWithValue("@e", idEquipo);
                    var o = cmd.ExecuteScalar();
                    cx.Desconectar();
                    return (o != null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error validando jugador/equipo: " + ex.Message); return false; }
        }

        public bool InsertarSancionSQL(int idPartido, int idEquipo, int idJugador, int minuto, string tipo, string detalle = null)
        {
            // Seguridad: verificar que el jugador pertenezca a ese equipo
            if (!JugadorPerteneceAlEquipo(idJugador, idEquipo))
            {
                MessageBox.Show("El jugador seleccionado no pertenece a ese equipo.");
                return false;
            }

            try
            {
                Conexion cx = new Conexion();
                string sql = @"INSERT INTO Sancion (partido, equipo, jugador, minuto, tipo)
                       VALUES (@p,@e,@j,@m,@t)";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@p", idPartido);
                    cmd.Parameters.AddWithValue("@e", idEquipo);
                    cmd.Parameters.AddWithValue("@j", idJugador);
                    cmd.Parameters.AddWithValue("@m", minuto);
                    cmd.Parameters.AddWithValue("@t", tipo); // 'GOL','TJA','TJR'
                    int c = cmd.ExecuteNonQuery();
                    cx.Desconectar();
                    return (c == 1);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error insertando sanción: " + ex.Message); return false; }
        }

        public bool FinalizarPartidoConSancionesSQL(
            int idPartido,
            List<(int idEquipo, int idJugador, int minuto, string tipo)> sanciones,
            int golesCasaFinal,
            int golesVisitaFinal)
        {
            try
            {
                Conexion cx = new Conexion();
                using (SqlConnection con = cx.Conectar())
                using (SqlTransaction tx = con.BeginTransaction())
                {
                    string sqlSancion = @"INSERT INTO Sancion (partido, equipo, jugador, minuto, tipo)
                                  VALUES (@p,@e,@j,@m,@t)";
                    foreach (var s in sanciones)
                    {
                        // (opcional) valida pertenencia aquí también si no lo hiciste en UI
                        using (var c1 = new SqlCommand(sqlSancion, con, tx))
                        {
                            c1.Parameters.AddWithValue("@p", idPartido);
                            c1.Parameters.AddWithValue("@e", s.idEquipo);
                            c1.Parameters.AddWithValue("@j", s.idJugador);
                            c1.Parameters.AddWithValue("@m", s.minuto);
                            c1.Parameters.AddWithValue("@t", s.tipo);
                            c1.ExecuteNonQuery();
                        }
                    }

                    string sqlPartido = @"UPDATE Partido
                                  SET golesCasa=@gc, golesVisita=@gv, estado='FINALIZADO'
                                  WHERE id=@id";
                    using (var c2 = new SqlCommand(sqlPartido, con, tx))
                    {
                        c2.Parameters.AddWithValue("@gc", golesCasaFinal);
                        c2.Parameters.AddWithValue("@gv", golesVisitaFinal);
                        c2.Parameters.AddWithValue("@id", idPartido);
                        c2.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar partido: " + ex.Message);
                return false;
            }
        }


        public DataTable ListarSancionesPorPartidoSQL(int idPartido)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                        string sql = @"
                SELECT s.id, s.minuto, s.tipo, s.detalle,
                       e.nombre AS Equipo, j.nombre AS Jugador, j.dorsal
                FROM Sancion s
                JOIN Equipo  e ON e.id = s.equipo
                JOIN Jugador j ON j.id = s.jugador
                WHERE s.partido = @p
                ORDER BY s.minuto, s.id;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@p", idPartido);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex) { MessageBox.Show("Error listando sanciones: " + ex.Message); }
            return dt;
        }

        public bool ActualizarMarcadorPartidoSQL(int idPartido, int golesCasa, int golesVisita)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = "UPDATE Partido SET golesCasa=@gc, golesVisita=@gv WHERE id=@id";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@gc", golesCasa);
                    cmd.Parameters.AddWithValue("@gv", golesVisita);
                    cmd.Parameters.AddWithValue("@id", idPartido);
                    int c = cmd.ExecuteNonQuery();
                    cx.Desconectar();
                    return c == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando marcador: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarEstadoPartidoSQL(int idPartido, string estado)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = "UPDATE Partido SET estado=@est WHERE id=@id";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@est", estado.ToUpperInvariant()); // PENDIENTE / EN_JUEGO / FINALIZADO
                    cmd.Parameters.AddWithValue("@id", idPartido);
                    int c = cmd.ExecuteNonQuery();
                    cx.Desconectar();
                    return c == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando estado: " + ex.Message);
                return false;
            }
        }



        // Estas funciones se utilizan en la parte de emparejamientos
        public bool LimpiarPorTorneo(int idTorneo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM Partido WHERE torneo = " + idTorneo;
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                cmd.ExecuteNonQuery();
                conex.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error limpiando partidos del torneo: " + e.Message);
                return false;
            }
        }

        public bool GuardarLista(List<Partido> lista)
        {
            if (lista == null || lista.Count == 0) return true;

            try
            {
                Conexion conex = new Conexion();
                SqlConnection con = conex.Conectar();

                foreach (var p in lista)
                {
                    // Aseguramos valores por si vienen nulos
                    int torneo = p.Torneo;
                    int casa = p.EquipoCasa;
                    int visita = p.EquipoVisita;

                    string sql = "INSERT INTO Partido " +
                                 "(torneo, equipoCasa, equipoVisita, golesCasa, golesVisita, fase, estado) VALUES (" +
                                 torneo + ", " +
                                 casa + ", " +
                                 visita + ", " +
                                 "0, 0, 'REGULAR', 'PENDIENTE')";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }

                conex.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error guardando lista de partidos: " + e.Message);
                return false;
            }
        }
    }
}

