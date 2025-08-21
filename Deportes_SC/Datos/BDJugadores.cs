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

            // 1) Edad permitida por categoría del torneo (igual a tu lógica actual)
            int categoriaEdad = validarEdad(j.Equipo);

            // 2) Máximo de jugadores por equipo (tu lógica actual)
            if (validarMaximoJugadores(j.Equipo) >= 12)
            {
                MessageBox.Show("Este equipo ya tiene el máximo de 12 jugadores permitidos.");
                return false;
            }

            // 3) Validación de edad concreta del jugador
            int edad = CalcularEdad(j.FechaNacimiento);
            if (categoriaEdad > 0 && edad > categoriaEdad)
            {
                MessageBox.Show($"El jugador tiene {edad} años y supera la edad permitida ({categoriaEdad} años).");
                return false;
            }

            // 4) ***Nueva*** validación de GÉNERO (JOIN Equipo->Torneo y comparación)
            string generoTorneo = ObtenerGeneroTorneoPorEquipo(j.Equipo); // "Masculino" o "Femenino"
            if (string.IsNullOrWhiteSpace(generoTorneo))
            {
                MessageBox.Show("No se pudo determinar el género del torneo para este equipo.");
                return false;
            }

            if (!GeneroCoincideConTorneo(generoTorneo, j.Genero))
            {
                MessageBox.Show($"Género inválido: el torneo es '{generoTorneo}' y el jugador es '{j.Genero}'.");
                return false;
            }

            // 5) Si existe -> UPDATE; si no -> INSERT (tu mismo patrón)
            if (BuscarJugadorSQL(j.Identificador) != 0)
            {
                sql = "UPDATE Jugador SET " +
                      "cedula = '" + j.Cédula + "', " +
                      "nombre = '" + j.Nombre + "', " +
                      "genero = '" + j.Genero + "', " +
                      "posicion = '" + j.Posicion + "', " +
                      "dorsal = " + j.Dorsal + ", " +
                      "idEquipo = " + j.Equipo + ", " +
                      "fechaNacimiento = '" + j.FechaNacimiento.ToString("yyyy-MM-dd") + "' " +
                      "WHERE id = " + j.Identificador;
            }
            else
            {
                sql = "INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, idEquipo, fechaNacimiento) VALUES (" +
                      j.Identificador + ", '" +
                      j.Cédula + "', '" +
                      j.Nombre + "', '" +
                      j.Genero + "', '" +
                      j.Posicion + "', " +
                      j.Dorsal + ", " +
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
            // UPDATE corregido: se asigna el valor de dorsal correctamente
            string sql = "UPDATE Jugador SET " +
                         "cedula = '" + j.Cédula + "', " +
                         "nombre = '" + j.Nombre + "', " +
                         "genero = '" + j.Genero + "', " +
                         "posicion = '" + j.Posicion + "', " +
                         "dorsal = " + j.Dorsal + ", " +
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

        public DataTable ListarJugadoresSQL()
        {
            var dt = new DataTable();
            string sql = @"
        SELECT 
            j.id               AS Id,              -- visible
            j.cedula           AS Cedula,          -- visible
            j.nombre           AS Nombre,          -- visible
            j.posicion         AS Posicion,        -- visible
            j.dorsal           AS Dorsal,          -- visible
            e.nombre           AS NombreEquipo,    -- visible
            j.genero           AS Genero,          -- oculto (para editar)
            j.fechaNacimiento  AS FechaNacimiento, -- oculto (para editar)
            j.idEquipo         AS IdEquipo         -- oculto (para editar/Combo)
        FROM Jugador j
        JOIN Equipo e ON j.idEquipo = e.id;";

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
                MessageBox.Show("Error al listar jugadores: " + ex.Message);
            }

            return dt;
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

        //-----------------------------------------------

        private string ObtenerGeneroTorneoPorEquipo(int idEquipo)
        {
            string genero = "";
            try
            {
                Conexion conex = new Conexion();
                string sql = @"
            SELECT t.categoriaGenero
            FROM Equipo e
            JOIN Torneo t ON e.idTorneo = t.id
            WHERE e.id = " + idEquipo;

                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    genero = dr["categoriaGenero"]?.ToString() ?? "";
                }

                dr.Close();
                conex.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener género del torneo: " + ex.Message);
            }
            return genero;
        }

        private bool GeneroCoincideConTorneo(string generoTorneo, string generoJugador)
        {
            if (string.IsNullOrWhiteSpace(generoTorneo) || string.IsNullOrWhiteSpace(generoJugador))
                return false;

            // Compara ignorando mayúsculas/minúsculas y espacios
            generoTorneo = generoTorneo.Trim();
            generoJugador = generoJugador.Trim();

            return generoTorneo.Equals(generoJugador, StringComparison.OrdinalIgnoreCase);
        }

    }
}
