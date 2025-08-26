using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportes_SC.Objetos;
using System.Windows.Forms;

namespace Deportes_SC.Datos
{
    public class BDTorneos
    {
        public int BuscarTorneoSQL(int miID)
        {
            int encontrado = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id FROM Torneo WHERE id = " + miID;
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

        // Guardar
        public bool guardarTorneoSQL(Torneo t)
        {
            string sql;

            if (BuscarTorneoSQL(t.Identificador) != 0)
            {
                sql = "UPDATE Torneo SET " +
                      "nombre = '" + t.Nombre + "', " +
                      "categoriaEtaria = '" + t.CategoriaEtaria + "', " +
                      "categoriaGenero = '" + t.CategoriaGenero + "', " +
                      "año = '" + t.Año.ToString("yyyy-MM-dd") + "' " +
                      "WHERE id = " + t.Identificador;
            }
            else
            {
                sql = "INSERT INTO Torneo (id, nombre, categoriaEtaria, categoriaGenero, año) VALUES (" +
                      t.Identificador + ", '" +
                      t.Nombre + "', '" +
                      t.CategoriaEtaria + "', '" +
                      t.CategoriaGenero + "', '" +
                      t.Año.ToString("yyyy-MM-dd") + "')";
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

        // Modificar
        public bool modificarTorneoSQL(Torneo t)
        {
            string sql = "UPDATE Torneo SET " +
                         "nombre = '" + t.Nombre + "', " +
                         "categoriaEtaria = '" + t.CategoriaEtaria + "', " +
                         "categoriaGenero = '" + t.CategoriaGenero + "', " +
                         "año = '" + t.Año.ToString("yyyy-MM-dd") + "' " +
                         "WHERE id = " + t.Identificador;

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

        // Eliminar
        public bool eliminarTorneoSQL(int idTorneo)
        {
            string sql = "DELETE FROM Torneo WHERE id = " + idTorneo;

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

        public List<Torneo> mostrarTorneosSQL()
        {
            List<Torneo> lista = new List<Torneo>();
            string sql = "SELECT id, nombre, categoriaEtaria, categoriaGenero, año FROM Torneo";

            try
            {
                Conexion conex = new Conexion();
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Torneo t = new Torneo();
                    t.Identificador = Convert.ToInt32(lector["id"]);
                    t.Nombre = lector["nombre"].ToString();
                    t.CategoriaEtaria = lector["categoriaEtaria"].ToString();
                    t.CategoriaGenero = lector["categoriaGenero"].ToString();
                    t.Año = Convert.ToDateTime(lector["año"]);

                    lista.Add(t);
                }

                lector.Close();
                conex.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar torneos: " + ex.Message);
            }

            return lista;
        }

    }
}
