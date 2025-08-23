using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportes_SC.Datos
{
    public class BDEstadistica
    {

        // ------------------------ Datos Goleadores ------------------------//

        // Funcion para sacar los goleadores
        public DataTable TopGoleadoresSQL(int idTorneo, int topN = 10)
        {
            if (topN <= 0) topN = 10;  // Validar el top 10

            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
                    SELECT TOP (@topN)
                        j.cedula AS Cedula,
                        j.nombre AS Nombre,
                        e.nombre AS NombreEquipo,
                        COUNT(*) AS Cantidad
                    FROM Sancion s
                    JOIN Jugador j ON j.id = s.jugador
                    JOIN Equipo  e ON e.id = s.equipo
                    JOIN Partido p ON p.id = s.partido
                    WHERE s.tipo = 'GOL'
                      AND (@idTorneo = 0 OR p.torneo = @idTorneo)
                    GROUP BY j.cedula, j.nombre, e.nombre
                    ORDER BY Cantidad DESC, Nombre ASC;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@topN", topN);
                    cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error TopGoleadores: " + ex.Message);
            }
            return dt;
        }
    }
}
