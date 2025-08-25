using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportes_SC.Objetos;

namespace Deportes_SC.Datos
{
    public class BDEquipos
    {
        public int BuscarEquipoSQL(int miID)
        {
            int encontrado = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id FROM Equipo WHERE id = " + miID;
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = Convert.ToInt32(dr["id"].ToString());
                }

                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return encontrado;
        }

        public bool guardarEquipoSQL(Equipo e)
        {
            string sql;

            if (BuscarEquipoSQL(e.Identificador) != 0)
            {
                sql = "UPDATE Equipo SET " +
                      "nombre = '" + e.Nombre + "', " +
                      "lugarOrigen = '" + e.LugarOrigen + "', " +
                      "encargado = '" + e.Encargado + "', " +
                      "telefono = '" + e.Telefono + "', " +
                      "idTorneo = " + e.Torneo + " " +
                      "WHERE id = " + e.Identificador;
            }
            else
            {
                sql = "INSERT INTO Equipo (id, nombre, lugarOrigen, encargado, telefono, idTorneo) VALUES (" +
                      e.Identificador + ", '" +
                      e.Nombre + "', '" +
                      e.LugarOrigen + "', '" +
                      e.Encargado + "', '" +
                      e.Telefono + "', " +
                      e.Torneo + ")";
            }

            try
            {
                Conexion conex = new Conexion();
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

                conex.Desconectar();

                return cantidad == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool modificarEquipoSQL(Equipo e)
        {
            string sql = "UPDATE Equipo SET " +
                         "nombre = '" + e.Nombre + "', " +
                         "lugarOrigen = '" + e.LugarOrigen + "', " +
                         "encargado = '" + e.Encargado + "', " +
                         "telefono = '" + e.Telefono + "', " +
                         "idTorneo = " + e.Torneo + " " +
                         "WHERE id = " + e.Identificador;

            try
            {
                Conexion conex = new Conexion();
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

                conex.Desconectar();

                return cantidad == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool eliminarEquipoSQL(int idEquipo)
        {
            string sql = "DELETE FROM Equipo WHERE id = " + idEquipo;

            try
            {
                Conexion conex = new Conexion();
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

                conex.Desconectar();

                return cantidad == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable ListarEquiposSQL()
        {
            var dt = new DataTable();
            string sql = @"
        SELECT
            e.id           AS Id,            -- visible
            e.nombre       AS Nombre,        -- visible
            e.lugarOrigen  AS LugarOrigen,   -- visible
            t.nombre       AS NombreTorneo,  -- visible
            e.encargado    AS Encargado,     -- oculto (para editar)
            e.telefono     AS Telefono,      -- oculto (para editar)
            e.idTorneo     AS IdTorneo       -- oculto (para editar/Combo)
        FROM Equipo e
        JOIN Torneo t ON e.idTorneo = t.id;";

            try
            {
                using (SqlConnection conn = new Conexion().Conectar())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    dt.Load(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar equipos: " + ex.Message);
            }

            return dt;
        }

        public List<int> ListarIdsPorTorneo(int idTorneo)
        {
            List<int> ids = new List<int>();
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id FROM Equipo WHERE idTorneo = " + idTorneo + " ORDER BY id";
                SqlCommand cmd = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ids.Add(Convert.ToInt32(dr["id"]));
                }

                dr.Close();
                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error listando equipos por torneo: " + e.Message);
            }
            return ids;
        }

        public Dictionary<int, string> DiccionarioNombresPorTorneo(int idTorneo)
        {
            var map = new Dictionary<int, string>();
            try
            {
                Conexion cx = new Conexion();
                string sql = "SELECT id, nombre FROM Equipo WHERE idTorneo = @t ORDER BY nombre";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["id"]);
                            string nom = dr["nombre"].ToString();
                            map[id] = nom;
                        }
                    }
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando nombres de equipos: " + ex.Message);
            }
            return map;
        }


    }
}
        

