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

        // Inserta una lista de partidos (en transacción)
        public int InsertarPartidos(List<Partido> lista)
        {
            int cont = 0;
            if (lista == null || lista.Count == 0) return cont;

            try
            {
                Conexion conex = new Conexion();
                SqlConnection cn = conex.Conectar();
                SqlTransaction tx = cn.BeginTransaction();

                // Ajusta los nombres de columnas a tu tabla real (ver script al final)
                string sql = @"
                    INSERT INTO Partido
                    (torneo, jornada, fechaHora, equipoCasa, equipoVisita, golesCasa, golesVisita, fase, estado)
                    VALUES (@torneo, @jornada, @fecha, @casa, @visita, @golesC, @golesV, @fase, @estado)";

                using (SqlCommand cmd = new SqlCommand(sql, cn, tx))
                {
                    cmd.Parameters.Add("@torneo", SqlDbType.Int);
                    cmd.Parameters.Add("@jornada", SqlDbType.Int);
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                    cmd.Parameters.Add("@casa", SqlDbType.Int);
                    cmd.Parameters.Add("@visita", SqlDbType.Int);
                    cmd.Parameters.Add("@golesC", SqlDbType.Int);
                    cmd.Parameters.Add("@golesV", SqlDbType.Int);
                    cmd.Parameters.Add("@fase", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20);

                    foreach (var p in lista)
                    {
                        cmd.Parameters["@torneo"].Value = p.Torneo;
                        cmd.Parameters["@jornada"].Value = p.Jornada;
                        cmd.Parameters["@fecha"].Value = p.FechaHora;
                        cmd.Parameters["@casa"].Value = p.EquipoCasa;
                        cmd.Parameters["@visita"].Value = p.EquipoVisita;
                        cmd.Parameters["@golesC"].Value = p.GolesCasa;
                        cmd.Parameters["@golesV"].Value = p.GolesVisita;
                        cmd.Parameters["@fase"].Value = p.Fase ?? "REGULAR";
                        cmd.Parameters["@estado"].Value = p.Estado ?? "PENDIENTE";

                        cont += cmd.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                conex.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar partidos: " + ex.Message);
            }
            return cont;
        }

        // (Opcional) Para mostrar desde BD
        public DataTable ListarPartidosPorTorneo(int idTorneo, string fase)
        {
            var dt = new DataTable();
            try
            {
                Conexion conex = new Conexion();
                string sql = @"
                    SELECT p.jornada,
                           (SELECT nombre FROM Equipo WHERE id = p.equipoCasa)  AS Casa,
                           (SELECT nombre FROM Equipo WHERE id = p.equipoVisita) AS Visita,
                           p.fechaHora,
                           p.estado
                    FROM Partido p
                    WHERE p.torneo = @t AND p.fase = @f
                    ORDER BY p.jornada, p.fechaHora";
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                cmd.Parameters.AddWithValue("@t", idTorneo);
                cmd.Parameters.AddWithValue("@f", fase);
                SqlDataReader r = cmd.ExecuteReader();
                dt.Load(r);
                conex.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar partidos: " + ex.Message);
            }
            return dt;
        }

        public bool LimpiarPorTorneo(int idTorneo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM Partido WHERE idTorneo = " + idTorneo;
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
                int nextId = ObtenerSiguienteId();

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
                                 "(id, idTorneo, jornada, fechaHora, idEquipoCasa, idEquipoVisita, golesCasa, golesVisita, fase, estado) VALUES (" +
                                 nextId + ", " +
                                 torneo + ", " +
                                 jornada + ", " +
                                 "'1900-01-01', " +
                                 casa + ", " +
                                 visita + ", " +
                                 "0, 0, 'REGULAR', 'PENDIENTE')";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    // Asignar el id generado al objeto (por si lo necesitas luego)
                    p.Identificador = nextId;
                    nextId++;
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

