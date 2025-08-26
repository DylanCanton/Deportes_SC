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
    public class BDUsuarios
    {

        public int BuscarUsuarioSQL(int miID)
        {
            int encontrado = 0;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id FROM Usuario WHERE id = " + miID;
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
        public bool guardarUsuarioSQL(Usuario u)
        {
            String sql;

            if (BuscarUsuarioSQL(u.Id) != 0)
            {
                sql = "UPDATE Usuario SET " +
                      "nombre = '" + u.Nusuario + "', " +
                      "contrasenna = '" + u.Contrasenna + "', " +
                      "rol = '" + u.Rol + "', " +
                      "estado = " + u.Estado + " " +
                      "WHERE id = " + u.Id;
            }
            else
            {
                sql = "INSERT INTO Usuario (id, nombre, contrasenna, rol, estado) VALUES (" +
                      u.Id + ", '" +
                      u.Nusuario + "', '" +
                      u.Contrasenna + "', '" +
                      u.Rol + "', " +
                      u.Estado + ")";
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
        public bool modificarUsuarioSQL(Usuario u)
        {
            string sql = "UPDATE Usuario SET " +
                  "nombre = '" + u.Nusuario + "', " +
                  "contrasenna = '" + u.Contrasenna + "', " +
                  "rol = '" + u.Rol + "', " +
                  "estado = " + u.Estado + " " +
                  "WHERE id = " + u.Id;

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
        public bool eliminarUsuarioSQL(int idUsuario)
        {
            string sql = "DELETE FROM Usuario WHERE id = " + idUsuario;

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

        public DataTable ListarUsuariosSQL()
        {
            var dt = new DataTable();

            string sql = @"
            SELECT
                u.id             AS Id,            -- visible
                u.nombre       AS Usuario,       -- visible
                u.rol            AS Rol,           -- visible
                CASE u.estado                      -- visible (texto para el grid)
                    WHEN 1 THEN 'Activo'
                    WHEN 0 THEN 'Inactivo'
                    ELSE 'Desconocido'
                END              AS EstadoTexto,
                u.contrasenna    AS Contrasenna,   -- oculto (para editar)
                u.estado         AS Estado         -- oculto (int para editar)
            FROM Usuario u;";

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
                MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }

            return dt;
        }

        // Validacion del usuario
        public string ValidarUsuario(string nombreUsuario, string contrasenna)
        {
            string rol = null;
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT rol FROM Usuario " +
                             "WHERE nombre = @nombre AND contrasenna = @contrasenna AND estado = 1";

                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenna", contrasenna);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    rol = dr["rol"].ToString(); // Devuelve el rol 
                }

                conex.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al validar usuario: " + e.Message);
            }

            return rol; // Aca retorna el rol y asi validamos para saber a que interfaz va
        }

    }
}
