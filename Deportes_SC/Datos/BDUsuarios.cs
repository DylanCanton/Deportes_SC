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
