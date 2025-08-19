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
                p.id, p.torneo, p.jornada, p.fechaHora,
                p.equipoCasa, p.equipoVisita, p.golesCasa, p.golesVisita,
                p.fase, p.estado,
                ec.nombre AS nombreCasa, ev.nombre AS nombreVisita
            FROM Partido p
            JOIN Equipo ec ON ec.id = p.equipoCasa
            JOIN Equipo ev ON ev.id = p.equipoVisita
            WHERE p.torneo = @t
              AND (@f IS NULL OR p.fase = @f)
            ORDER BY p.jornada, p.id";
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
                        p.Jornada = Convert.ToInt32(dr["jornada"]);
                        p.FechaHora = Convert.ToDateTime(dr["fechaHora"]);
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

        private int ObtenerSiguienteId()
        {
            int siguiente = 1;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT ISNULL(MAX(id), 0) + 1 AS nextId FROM Partido";
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    siguiente = Convert.ToInt32(dr["nextId"]);
                dr.Close();
                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error obteniendo siguiente id de Partido: " + e.Message);
            }
            return siguiente;
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
                    int jornada = p.Jornada;
                    int casa = p.EquipoCasa;
                    int visita = p.EquipoVisita;

                    string sql = "INSERT INTO Partido " +
                                 "(torneo, jornada, fechaHora, equipoCasa, equipoVisita, golesCasa, golesVisita, fase, estado) VALUES (" +
                                 torneo + ", " +
                                 jornada + ", " +
                                 "'1900-01-01', " +
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

