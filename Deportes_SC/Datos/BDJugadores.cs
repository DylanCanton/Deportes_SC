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
    public class BDJugadores
    {
        public int BuscarJugadorSQL(int miID)
        {
            int encontrado = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id FROM Jugador WHERE id = " + miID;
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

        public bool GuardarJugadorSQL(Jugador j)
        {
            string sql;

            // Aqui obtenemos la edad de la categoria (para luego comparar)
            int categoriaEdad = validarEdad(j.Equipo);

            // Validamos la cantidad maxima de jugadores por equipo
            if (validarMaximoJugadores(j.Equipo) >= 12)
            {
                MessageBox.Show("Este equipo ya tiene el máximo de 12 jugadores permitidos.");
                return false;
            }

            // Aqui validamos la edad del jugador con la edad permitida en la categoria del torneo
            int edad = CalcularEdad(j.FechaNacimiento);
            if (categoriaEdad > 0 && edad > categoriaEdad)
            {
                MessageBox.Show($"El jugador tiene {edad} años y supera la edad permitida ({categoriaEdad} años).");
                return false;
            }

            if (BuscarJugadorSQL(j.Identificador) != 0)
            {
                sql = "UPDATE Jugador SET " +
                      "cedula = '" + j.Cédula + "', " +
                      "nombre = '" + j.Nombre + "', " +
                      "genero = '" + j.Genero + "', " +
                      "posicion = '" + j.Posicion + "', " +
                      "idEquipo = " + j.Equipo + ", " +
                      "fechaNacimiento = '" + j.FechaNacimiento.ToString("yyyy-MM-dd") + "' " +
                      "WHERE id = " + j.Identificador;
            }
            else
            {
                sql = "INSERT INTO Jugador (id, cedula, nombre, genero, posicion, idEquipo, fechaNacimiento) VALUES (" +
                      j.Identificador + ", '" +
                      j.Cédula + "', '" +
                      j.Nombre + "', '" +
                      j.Genero + "', '" +
                      j.Posicion + "', " +
                      j.Equipo + ", '" +
                      j.FechaNacimiento.ToString("yyyy-MM-dd") + "')";
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

        public bool modificarJugadorSQL(Jugador j)
        {
            string sql = "UPDATE Jugador SET " +
                         "cedula = '" + j.Cédula + "', " +
                         "nombre = '" + j.Nombre + "', " +
                         "genero = '" + j.Genero + "', " +
                         "posicion = '" + j.Posicion + "', " +
                         "idEquipo = " + j.Equipo + ", " +
                         "fechaNacimiento = '" + j.FechaNacimiento.ToString("yyyy-MM-dd") + "' " +
                         "WHERE id = " + j.Identificador;

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


        public bool eliminarEquipoSQL(int id)
        {
            string sql = "DELETE FROM Jugador WHERE id = " + id;

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

        public List<Jugador> mostrarJugadoresSQL()
        {
            List<Jugador> lista = new List<Jugador>();

            string sql = @"SELECT 
                        j.id, 
                        j.cedula, 
                        j.nombre, 
                        j.genero, 
                        j.posicion, 
                        j.fechaNacimiento, 
                        j.idEquipo, 
                        e.nombre AS nombreEquipo
                   FROM Jugador j
                   JOIN Equipo e ON j.idEquipo = e.id";

            try
            {
                using (SqlConnection conn = new Conexion().Conectar())
                {
                    SqlCommand comando = new SqlCommand(sql, conn);
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Jugador j = new Jugador();
                        j.Identificador = Convert.ToInt32(lector["id"]);
                        j.Cédula = lector["cedula"].ToString();
                        j.Nombre = lector["nombre"].ToString();
                        j.Genero = lector["genero"].ToString();
                        j.Posicion = lector["posicion"].ToString();
                        j.FechaNacimiento = Convert.ToDateTime(lector["fechaNacimiento"]);
                        j.Equipo = Convert.ToInt32(lector["idEquipo"]);
                        j.NombreEquipo = lector["nombreEquipo"].ToString();

                        lista.Add(j);
                    }

                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar jugadores: " + ex.Message);
            }

            return lista;
        }

        //--------------------------------------------------------------------------//
        // Validaciones para el jugador
        public int validarMaximoJugadores(int idEquipo)
        {
            int cantidad = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT COUNT(*) AS total FROM Jugador WHERE idEquipo = " + idEquipo;
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    cantidad = Convert.ToInt32(dr["total"].ToString());
                }

                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cantidad;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;

            
            if (fechaNacimiento.Date > hoy) return -1;

            int edad = hoy.Year - fechaNacimiento.Year;

            // Si aún no llegó el cumpleaños este año, restar 1
            if (fechaNacimiento.Month > hoy.Month ||
               (fechaNacimiento.Month == hoy.Month && fechaNacimiento.Day > hoy.Day))
            {
                edad--;
            }

            return edad;
        }


        //Funcion para validar que la edad del jugador sea permitida para el torneo del equipo
        public int validarEdad(int idEquipo)
        {
            int categoria = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = @"SELECT t.categoriaEtaria
                       FROM Equipo e
                       JOIN Torneo t ON e.idTorneo = t.id
                       WHERE e.id = " + idEquipo;

                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    // Convertir la categoría etaria (varchar) a número
                    int.TryParse(dr["categoriaEtaria"].ToString(), out categoria);
                }

                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return categoria;
        }

    }
}
