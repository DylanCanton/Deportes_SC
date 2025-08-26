using Deportes_SC.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deportes_SC.Datos
{
    public class BDPartidos
    {
        // Verificar partidos
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
                    ORDER BY p.id"; 

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

        public bool FinalizarPartidoSQL(
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

        // Actualizar luego de terminar el partido
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
                    cmd.Parameters.AddWithValue("@est", estado.ToUpperInvariant()); // PENDIENTE / EN JUEGO / FINALIZADO
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


        // -------------------------- Codigo para agregar sanciones --------------------------------//

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

        public int ContarAmarillasJugadorEnTorneo(int idJugador, int idTorneo)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
            SELECT COUNT(*) 
            FROM Sancion s
            JOIN Partido p ON p.id = s.partido
            WHERE s.tipo = 'TJA' AND s.jugador = @j AND p.torneo = @t;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@j", idJugador);
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    int c = Convert.ToInt32(cmd.ExecuteScalar());
                    cx.Desconectar();
                    return c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error contando amarillas: " + ex.Message);
                return 0;
            }
        }


        public DataTable ListarSancionesPorPartidoSQL(int idPartido)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
                SELECT s.id, s.minuto, s.tipo,
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
                using (SqlConnection con = conex.Conectar())
                using (SqlTransaction tx = con.BeginTransaction())
                {
                    string sql = @"
                INSERT INTO Partido
                (torneo, equipoCasa, equipoVisita, golesCasa, golesVisita, fase, estado)
                VALUES
                (@t, @casa, @visita, @gc, @gv, @fase, @est)";

                    using (var cmd = new SqlCommand(sql, con, tx))
                    {
                        cmd.Parameters.Add("@t", SqlDbType.Int);
                        cmd.Parameters.Add("@casa", SqlDbType.Int);
                        cmd.Parameters.Add("@visita", SqlDbType.Int);
                        cmd.Parameters.Add("@gc", SqlDbType.Int);
                        cmd.Parameters.Add("@gv", SqlDbType.Int);
                        cmd.Parameters.Add("@fase", SqlDbType.VarChar, 20);
                        cmd.Parameters.Add("@est", SqlDbType.VarChar, 20);

                        foreach (var p in lista)
                        {
                            cmd.Parameters["@t"].Value = p.Torneo;
                            cmd.Parameters["@casa"].Value = p.EquipoCasa;
                            cmd.Parameters["@visita"].Value = p.EquipoVisita;
                            cmd.Parameters["@gc"].Value = p.GolesCasa;
                            cmd.Parameters["@gv"].Value = p.GolesVisita;
                            cmd.Parameters["@fase"].Value = string.IsNullOrWhiteSpace(p.Fase) ? "REGULAR" : p.Fase.ToUpperInvariant();
                            cmd.Parameters["@est"].Value = string.IsNullOrWhiteSpace(p.Estado) ? "PENDIENTE" : p.Estado.ToUpperInvariant();

                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
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



        // ELIMINAR SOLO UNA FASE
        public bool EliminarFase(int idTorneo, string fase)
        {
            try
            {
                Conexion conex = new Conexion();
                const string sql = "DELETE FROM Partido WHERE torneo = @t AND fase = @f";
                using (var cmd = new SqlCommand(sql, conex.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    cmd.Parameters.AddWithValue("@f", fase);
                    cmd.ExecuteNonQuery();
                }
                conex.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando fase: " + ex.Message);
                return false;
            }
        }

        // ¿TODOS LOS PARTIDOS DE LA FASE TERMINADOS?
        // (no hay ninguno con estado <> 'Finalizado')
        public bool FaseTerminada(int idTorneo, string fase)
        {
            try
            {
                Conexion conex = new Conexion();
                const string sql = @"
            SELECT COUNT(*) 
            FROM Partido 
            WHERE torneo=@t AND fase=@f AND UPPER(estado) <> 'FINALIZADO'";
                int pendientes;
                using (var cmd = new SqlCommand(sql, conex.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    cmd.Parameters.AddWithValue("@f", fase.ToUpperInvariant());
                    pendientes = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conex.Desconectar();
                return pendientes == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validando fase: " + ex.Message);
                return false;
            }
        }


        private DataTable TablaPosicionesPorFaseSQL_Priv(int idTorneo, string fase)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                const string sql = @"
        WITH J AS (
            SELECT 
                e.id     AS IdEquipo,
                e.nombre AS Equipo,
                CASE WHEN p.equipoCasa = e.id THEN p.golesCasa ELSE p.golesVisita END AS GF,
                CASE WHEN p.equipoCasa = e.id THEN p.golesVisita ELSE p.golesCasa END AS GC,
                CASE 
                    WHEN (p.equipoCasa = e.id AND p.golesCasa > p.golesVisita) 
                      OR (p.equipoVisita = e.id AND p.golesVisita > p.golesCasa) 
                    THEN 1 ELSE 0 END AS Win,
                CASE WHEN p.golesCasa = p.golesVisita THEN 1 ELSE 0 END AS Draw,
                CASE 
                    WHEN (p.equipoCasa = e.id AND p.golesCasa < p.golesVisita) 
                      OR (p.equipoVisita = e.id AND p.golesVisita < p.golesCasa) 
                    THEN 1 ELSE 0 END AS Loss
            FROM Equipo e
            JOIN Partido p 
              ON p.torneo = @t
             AND UPPER(p.fase) = @f
             AND UPPER(p.estado) = 'FINALIZADO'
             AND (p.equipoCasa = e.id OR p.equipoVisita = e.id)
        )
        SELECT
            IdEquipo,
            Equipo,
            COUNT(*)               AS PJ,
            SUM(Win)               AS PG,
            SUM(Draw)              AS PE,
            SUM(Loss)              AS PP,
            SUM(GF)                AS GF,
            SUM(GC)                AS GC,
            SUM(GF) - SUM(GC)      AS DG,
            SUM(Win)*3 + SUM(Draw) AS Pts
        FROM J
        GROUP BY IdEquipo, Equipo
        -- ORDEN correcto según enunciado: Puntos, luego MÁS GOLES a favor, luego alfabético
        ORDER BY Pts DESC, GF DESC, Equipo ASC";

                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    cmd.Parameters.AddWithValue("@f", fase);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando tabla de posiciones: " + ex.Message);
            }
            return dt;
        }


        // TOP K CLASIFICADOS
        public List<int> TopKClasificadosPorFase(int idTorneo, string fase, int kDeseado)
        {
            var ids = new List<int>();
            try
            {
                var tabla = TablaPosicionesPorFaseSQL_Priv(idTorneo, fase?.ToUpperInvariant());
                if (tabla.Rows.Count == 0) return ids;

                int k = Math.Min(kDeseado, tabla.Rows.Count);
                for (int i = 0; i < k; i++)
                    ids.Add(Convert.ToInt32(tabla.Rows[i]["IdEquipo"]));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obteniendo TopK por fase: " + ex.Message);
            }
            return ids;
        }

        public List<int> TopKClasificados(int idTorneo, int kDeseado)
        {
            // Top por PUNTOS de la fase REGULAR
            return TopKClasificadosPorFase(idTorneo, "REGULAR", kDeseado);
        }

        public bool ExisteGranFinal(int idTorneo)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = "SELECT TOP 1 1 FROM Partido WHERE torneo=@t AND UPPER(fase)='GRAN_FINAL'";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    var o = cmd.ExecuteScalar();
                    cx.Desconectar();
                    return o != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verificando gran final: " + ex.Message);
                return false;
            }
        }


        public bool GenerarGranFinalSQL(int idTorneo, int idEquipo1, int idEquipo2)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
            INSERT INTO Partido (torneo, equipoCasa, equipoVisita, golesCasa, golesVisita, fase, estado)
            VALUES (@t, @casa, @visita, 0, 0, 'GRAN_FINAL', 'PENDIENTE')";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    cmd.Parameters.AddWithValue("@casa", idEquipo1);
                    cmd.Parameters.AddWithValue("@visita", idEquipo2);
                    int c = cmd.ExecuteNonQuery();
                    cx.Desconectar();
                    return c == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando Gran Final: " + ex.Message);
                return false;
            }
        }


        public (int idEquipo, string nombre) ObtenerCampeonSQL(int idTorneo)
        {
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
            SELECT TOP 1 p.equipoCasa, p.equipoVisita, p.golesCasa, p.golesVisita,
                         ec.nombre AS nombreCasa, ev.nombre AS nombreVisita
            FROM Partido p
            JOIN Equipo ec ON ec.id = p.equipoCasa
            JOIN Equipo ev ON ev.id = p.equipoVisita
            WHERE p.torneo=@t AND UPPER(p.fase)='GRAN_FINAL' AND UPPER(p.estado)='FINALIZADO'
            ORDER BY p.id DESC";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read()) return (0, null);
                        int c = Convert.ToInt32(r["equipoCasa"]);
                        int v = Convert.ToInt32(r["equipoVisita"]);
                        int gc = Convert.ToInt32(r["golesCasa"]);
                        int gv = Convert.ToInt32(r["golesVisita"]);
                        string nc = Convert.ToString(r["nombreCasa"]);
                        string nv = Convert.ToString(r["nombreVisita"]);
                        if (gc == gv) return (0, "Empate en Gran Final");
                        return (gc > gv) ? (c, nc) : (v, nv);
                    }
                }
            }
            catch { return (0, null); }
        }


    }
}

