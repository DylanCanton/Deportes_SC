using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deportes_SC.Datos
{
    public class BDEstadistica
    {
        // ------------------------ Datos Goleadores ------------------------//

        // Top goleadores (si idTorneo = 0, trae de todos los torneos)
        public DataTable TopGoleadoresSQL(int idTorneo, int topN = 10)
        {
            if (topN <= 0) topN = 10;  // Asegurar un top válido

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

        // ------------------------ Tabla de Posiciones ------------------------//

        // Tabla de posiciones por torneo (3-1-0) usando partidos FINALIZADOS
        public DataTable TablaPosicionesPorTorneoSQL(int idTorneo)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                const string sql = @"
                WITH J AS (
                    SELECT 
                        e.id     AS IdEquipo,
                        e.nombre AS Equipo,
                        CASE WHEN p.equipoCasa = e.id THEN p.golesCasa ELSE p.golesVisita END AS GF,
                        CASE WHEN p.equipoCasa = e.id THEN p.golesVisita ELSE p.golesCasa END AS GC,
                        CASE 
                            WHEN (p.equipoCasa = e.id AND p.golesCasa > p.golesVisita) 
                              OR (p.equipoVisita = e.id AND p.golesVisita > p.golesCasa) 
                            THEN 1 ELSE 0 END AS Win,
                        CASE WHEN p.golesCasa = p.golesVisita THEN 1 ELSE 0 END AS Draw,
                        CASE 
                            WHEN (p.equipoCasa = e.id AND p.golesCasa < p.golesVisita) 
                              OR (p.equipoVisita = e.id AND p.golesVisita < p.golesCasa) 
                            THEN 1 ELSE 0 END AS Loss
                    FROM Equipo e
                    JOIN Partido p 
                      ON p.torneo = @t
                     AND p.estado = 'FINALIZADO'
                     AND (p.equipoCasa = e.id OR p.equipoVisita = e.id)
                )
                SELECT
                    IdEquipo,
                    Equipo,
                    COUNT(*)               AS PJ,
                    SUM(Win)               AS PG,
                    SUM(Draw)              AS PE,
                    SUM(Loss)              AS PP,
                    SUM(GF)                AS GF,
                    SUM(GC)                AS GC,
                    SUM(GF) - SUM(GC)      AS DG,
                    SUM(Win)*3 + SUM(Draw) AS Pts
                FROM J
                GROUP BY IdEquipo, Equipo
                ORDER BY Pts DESC, (SUM(GF)-SUM(GC)) DESC, SUM(GF) DESC, Equipo ASC";

                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@t", idTorneo);
                    using (var r = cmd.ExecuteReader())
                    {
                        dt.Load(r);
                    }
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando tabla de posiciones: " + ex.Message);
            }
            return dt;
        }

        // ------------------------ Tabla de Sanciones ------------------------//

        // ------------------------ Sanciones: por JUGADOR ------------------------ //
        public DataTable SancionesPorJugadorSQL(int idTorneo)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
                    SELECT 
                        j.cedula       AS Cedula,
                        j.nombre       AS Nombre,
                        e.nombre       AS NombreEquipo,
                        SUM(CASE WHEN s.tipo='TJA' THEN 1 ELSE 0 END) AS Amarillas,
                        SUM(CASE WHEN s.tipo='TAZ' THEN 1 ELSE 0 END) AS Azules,
                        SUM(CASE WHEN s.tipo='TJR' THEN 1 ELSE 0 END) AS Rojas,
                        SUM(CASE 
                                WHEN s.tipo='TJA' THEN 10000
                                WHEN s.tipo='TAZ' THEN 15000
                                WHEN s.tipo='TJR' THEN 25000
                                ELSE 0
                            END)
                        + ( (SUM(CASE WHEN s.tipo='TJA' THEN 1 ELSE 0 END) / 5) * 30000 ) AS Monto
                    FROM Sancion s
                    JOIN Jugador j ON j.id = s.jugador
                    JOIN Equipo  e ON e.id = s.equipo
                    JOIN Partido p ON p.id = s.partido
                    WHERE (@idTorneo = 0 OR p.torneo = @idTorneo)
                    GROUP BY j.cedula, j.nombre, e.nombre
                    ORDER BY Monto DESC, Nombre ASC;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SancionesPorJugador: " + ex.Message);
            }
            return dt;
        }

        // ------------------------ Sanciones: por EQUIPO ------------------------- //
        public DataTable SancionesPorEquipoSQL(int idTorneo)
        {
            var dt = new DataTable();
            try
            {
                Conexion cx = new Conexion();
                string sql = @"
                    WITH PorJugador AS (
                        SELECT 
                            e.id     AS IdEquipo,
                            e.nombre AS NombreEquipo,
                            s.jugador,
                            SUM(CASE WHEN s.tipo='TJA' THEN 1 ELSE 0 END) AS Amarillas,
                            SUM(CASE WHEN s.tipo='TAZ' THEN 1 ELSE 0 END) AS Azules,
                            SUM(CASE WHEN s.tipo='TJR' THEN 1 ELSE 0 END) AS Rojas,
                            SUM(CASE 
                                    WHEN s.tipo='TJA' THEN 10000
                                    WHEN s.tipo='TAZ' THEN 15000
                                    WHEN s.tipo='TJR' THEN 25000
                                    ELSE 0
                                END) AS MontoBase
                        FROM Sancion s
                        JOIN Equipo  e ON e.id = s.equipo
                        JOIN Partido p ON p.id = s.partido
                        WHERE (@idTorneo = 0 OR p.torneo = @idTorneo)
                        GROUP BY e.id, e.nombre, s.jugador
                    ),
                    PorEquipo AS (
                        SELECT
                            IdEquipo,
                            NombreEquipo,
                            SUM(Amarillas) AS Amarillas,
                            SUM(Azules)    AS Azules,
                            SUM(Rojas)     AS Rojas,
                            SUM(MontoBase + ((Amarillas / 5) * 30000)) AS Monto
                        FROM PorJugador
                        GROUP BY IdEquipo, NombreEquipo
                    )
                    SELECT * 
                    FROM PorEquipo
                    ORDER BY Monto DESC, NombreEquipo ASC;";
                using (var cmd = new SqlCommand(sql, cx.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
                    using (var r = cmd.ExecuteReader()) dt.Load(r);
                }
                cx.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SancionesPorEquipo: " + ex.Message);
            }
            return dt;
        }
    }
}
