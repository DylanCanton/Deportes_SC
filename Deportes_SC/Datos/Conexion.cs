using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Datos
{
    public class Conexion
    {
        SqlConnection con;

        String conector = "Data Source = Jeudy;" + // LAPTOP-1AMJQ3VT\\SQLEXPRESS
                          "Initial Catalog = Torneos;" + // Base de datos
                          "User = sa;" + // Usuario
                          "Password = 12345678;" + // 1234
                          "Integrated Security = True"; // Modelo de seguridad

        public Conexion()
        {
            con = new SqlConnection(conector);
        }

        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}