using System;
using System.Collections.Generic;
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

        public List<Equipo> mostrarEquiposSQL()
        {
            List<Equipo> lista = new List<Equipo>();
            string sql = @"SELECT 
                     e.id, 
                     e.nombre, 
                     e.lugarOrigen, 
                     e.encargado, 
                     e.telefono, 
                     e.idTorneo, 
                     t.nombre AS nombreTorneo
                   FROM Equipo e
                   JOIN Torneo t ON e.idTorneo = t.id";

            try
            {
                using (SqlConnection conn = new Conexion().Conectar())
                {
                    SqlCommand comando = new SqlCommand(sql, conn);
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Equipo e = new Equipo();
                        e.Identificador = Convert.ToInt32(lector["id"]);
                        e.Nombre = lector["nombre"].ToString();
                        e.LugarOrigen = lector["lugarOrigen"].ToString();
                        e.Encargado = lector["encargado"].ToString();
                        e.Telefono = lector["telefono"].ToString();
                        e.Torneo = Convert.ToInt32(lector["idTorneo"]);
                        e.NombreTorneo = lector["nombreTorneo"].ToString();

                        lista.Add(e);
                    }

                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar equipos: " + ex.Message);
            }

            return lista;
        }
    }
}
