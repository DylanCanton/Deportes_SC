using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportes_SC.Datos;

namespace Deportes_SC.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        /*-----------------------------------------------------------------------------*/

        public void Abrir_formhijo(object formhijo)
        {
            if (this.pnl_contenedor.Controls.Count > 0)
                this.pnl_contenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_contenedor.Controls.Add(fh);
            this.pnl_contenedor.Tag = fh;
            fh.Show();
        }
        // Asignacion de botones para abrir el form que corresponde :)
        private void btn_Torneos_Click(object sender, EventArgs e)
        {
            Abrir_formhijo(new FrmTorneos());
        }

        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            Abrir_formhijo(new FrmEquipos());
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            Abrir_formhijo(new FrmJugadores());
        }
        private void btn_Emparejamientos_Click(object sender, EventArgs e)
        {
            Abrir_formhijo(new FrmEmparejamientos());
        }

        private void btn_Partidos_Click(object sender, EventArgs e)
        {
            FrmPartidos frmPartidos = new FrmPartidos();
            frmPartidos.Show();

        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Abrir_formhijo(new FrmUsuarios());
        }

        private void btn_CargarDatos_Click(object sender, EventArgs e)
        {
            //Aqui va el codigo de carga de datos, o sea inserts predeterminados 
            Conexion conexion = new Conexion();
            SqlConnection conn = conexion.Conectar();

            if (conn == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                return;
            }

            string sqlInserts = @"
                -- Inserts de Usuarios

                IF NOT EXISTS (SELECT 1 FROM Usuario WHERE id = 1)
                INSERT INTO Usuario (id, nombre, contrasenna, rol, estado) VALUES
                (1, 'admin', '1234', 'Administrador', 1);

                IF NOT EXISTS (SELECT 1 FROM Usuario WHERE id = 2)
                INSERT INTO Usuario (id, nombre, contrasenna, rol, estado) VALUES
                (2, 'subadmin', '1234', 'SubAdministrador', 1);

                IF NOT EXISTS (SELECT 1 FROM Usuario WHERE id = 3)
                INSERT INTO Usuario (id, nombre, contrasenna, rol, estado) VALUES
                (3, 'arbitro1', '1234', 'Arbitro', 1);
                

                -- Inserts de Torneos

                IF NOT EXISTS (SELECT 1 FROM Torneo WHERE id = 1)
                INSERT INTO Torneo (id, nombre, categoriaEtaria, categoriaGenero, año) VALUES
                (1, 'Copa Invierno', 18, 'Masculino', '2025-01-01');

                IF NOT EXISTS (SELECT 1 FROM Torneo WHERE id = 2)
                INSERT INTO Torneo (id, nombre, categoriaEtaria, categoriaGenero, año) VALUES
                (2, 'Liga Juvenil', 15, 'Femenino', '2025-02-01');


                -- Inserts de Equipos

                IF NOT EXISTS (SELECT 1 FROM Equipo WHERE id = 1)
                INSERT INTO Equipo (id, nombre, lugarOrigen, encargado, telefono, idTorneo) VALUES
                (1, 'Futsal Guerreros', 'San José', 'Carlos Méndez', '88887777', 1);

                IF NOT EXISTS (SELECT 1 FROM Equipo WHERE id = 2)
                INSERT INTO Equipo (id, nombre, lugarOrigen, encargado, telefono, idTorneo) VALUES
                (2, 'Leonas del Gol', 'Cartago', 'María Pérez', '88886666', 2);


                -- Inserts de Jugadores

                IF NOT EXISTS (SELECT 1 FROM Jugador WHERE id = 2)
                INSERT INTO Jugador (id, cedula, nombre, genero, posicion, fechaNacimiento, idEquipo) VALUES
                (2, '1-1111-1111', 'Juan Rodríguez', 'Masculino', 'Portero', '2005-03-15', 1);

                IF NOT EXISTS (SELECT 1 FROM Jugador WHERE id = 3)
                INSERT INTO Jugador (id, cedula, nombre, genero, posicion, fechaNacimiento, idEquipo) VALUES
                (3, '2-2222-2222', 'Luis Gómez', 'Masculino', 'Pivot', '2004-07-20', 1);

                IF NOT EXISTS (SELECT 1 FROM Jugador WHERE id = 4)
                INSERT INTO Jugador (id, cedula, nombre, genero, posicion, fechaNacimiento, idEquipo) VALUES
                (4, '3-3333-3333', 'Ana Torres', 'Femenino', 'Ala Izquierda', '2009-09-10', 2);

                IF NOT EXISTS (SELECT 1 FROM Jugador WHERE id = 5)
                INSERT INTO Jugador (id, cedula, nombre, genero, posicion, fechaNacimiento, idEquipo) VALUES
                (5, '4-4444-4444', 'Sofía López', 'Femenino', 'Cierre', '2008-01-05', 2);
                ";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlInserts, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos precargados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Desconectar();
            }

        }

        private void cargarDatos_Click(object sender, EventArgs e)
        {
            {
                string sql = @"
            SET XACT_ABORT ON;
            BEGIN TRAN;

            ------------------------------------------------------------
            -- Limpieza
            ------------------------------------------------------------
            DELETE s
            FROM Sancion s
            JOIN Partido p ON p.id = s.partido
            WHERE p.torneo = 100;

            DELETE FROM Partido WHERE torneo = 100;

            DELETE FROM Jugador WHERE idEquipo IN (1001,1002,1003,1004,1005);

            DELETE FROM Equipo WHERE id IN (1001,1002,1003,1004,1005);

            DELETE FROM Torneo WHERE id = 100;

            -----------------------
            -- Insert Torneo
            -----------------------
            INSERT INTO Torneo (id, nombre, categoriaEtaria, categoriaGenero, año)
            VALUES (100, 'Champions League', 40, 'Masculino', '2025-01-01');

            --------------------------------
            -- Inserts Equipos
            --------------------------------
            INSERT INTO Equipo (id, nombre, lugarOrigen, encargado, telefono, idTorneo) VALUES
            (1001, 'Real Madrid',      'Madrid',     'Carlo Ancelotti',  '6000000001', 100),
            (1002, 'FC Barcelona',     'Barcelona',  'Xavi Hernández',   '6000000002', 100),
            (1003, 'Bayern Munich',    'Múnich',     'Thomas Tuchel',    '6000000003', 100),
            (1004, 'Manchester City',  'Manchester', 'Pep Guardiola',    '6000000004', 100),
            (1005, 'PSG',              'París',      'Luis Enrique',     '6000000005', 100);

            -------------------------------------------------
            -- Inserts Jugadores por Equipo
            -------------------------------------------------
            -- Real Madrid (1001): 2001..2005
            INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, fechaNacimiento, idEquipo) VALUES
            (2001,'1-0001-0001','Thibaut Courtois','Masculino','Portero',     1,  '1992-05-11',1001),
            (2002,'1-0001-0002','Dani Carvajal',   'Masculino','Defensa',     2,  '1992-01-11',1001),
            (2003,'1-0001-0003','Luka Modrić',     'Masculino','Mediocampista', 10,  '1985-09-09',1001),
            (2004,'1-0001-0004','Jude Bellingham', 'Masculino','Mediocampista',  5,  '2003-06-29',1001),
            (2005,'1-0001-0005','Vinícius Júnior', 'Masculino','Delantero',   7,  '2000-07-12',1001);

            -- Barcelona (1002): 2006..2010
            INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, fechaNacimiento, idEquipo) VALUES
            (2006,'1-0002-0001','Marc-André ter Stegen','Masculino','Portero',     1,  '1992-04-30',1002),
            (2007,'1-0002-0002','Ronald Araújo',        'Masculino','Defensa',     4,  '1999-03-07',1002),
            (2008,'1-0002-0003','Frenkie de Jong',      'Masculino','Mediocampista', 21,  '1997-05-12',1002),
            (2009,'1-0002-0004','Pedri',                 'Masculino','Mediocampista',  8,  '2002-11-25',1002),
            (2010,'1-0002-0005','Robert Lewandowski',   'Masculino','Delantero',   9,  '1988-08-21',1002);

            -- Bayern (1003): 2011..2015
            INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, fechaNacimiento, idEquipo) VALUES
            (2011,'1-0003-0001','Manuel Neuer',  'Masculino','Portero',     1,  '1986-03-27',1003),
            (2012,'1-0003-0002','Joshua Kimmich','Masculino','Defensa',     6,  '1995-02-08',1003),
            (2013,'1-0003-0003','Leon Goretzka', 'Masculino','Mediocampista',  8,  '1995-02-06',1003),
            (2014,'1-0003-0004','Jamal Musiala','Masculino','Mediocampista',  42,  '2003-02-26',1003),
            (2015,'1-0003-0005','Harry Kane',    'Masculino','Delantero',   9,  '1993-07-28',1003);

            -- Man City (1004): 2016..2020
            INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, fechaNacimiento, idEquipo) VALUES
            (2016,'1-0004-0001','Ederson',        'Masculino','Portero',     31, '1993-08-17',1004),
            (2017,'1-0004-0002','Rúben Dias',     'Masculino','Defensa',      3, '1997-05-14',1004),
            (2018,'1-0004-0003','Rodri',          'Masculino','Mediocampista',  16, '1996-06-22',1004),
            (2019,'1-0004-0004','Kevin De Bruyne','Masculino','Mediocampista',  17, '1991-06-28',1004),
            (2020,'1-0004-0005','Erling Haaland', 'Masculino','Delantero',    9, '2000-07-21',1004);

            -- PSG (1005): 2021..2025
            INSERT INTO Jugador (id, cedula, nombre, genero, posicion, dorsal, fechaNacimiento, idEquipo) VALUES
            (2021,'1-0005-0001','Gianluigi Donnarumma','Masculino','Portero',     1,  '1999-02-25',1005),
            (2022,'1-0005-0002','Marquinhos',          'Masculino','Defensa',     5,  '1994-05-14',1005),
            (2023,'1-0005-0003','Vitinha',             'Masculino','Mediocampista', 17,  '2000-02-13',1005),
            (2024,'1-0005-0004','Ousmane Dembélé',     'Masculino','Mediocampista', 10,  '1997-05-15',1005),
            (2025,'1-0005-0005','Kylian Mbappé',       'Masculino','Delantero',   7,  '1998-12-20',1005);

            -------------------------
            COMMIT;";

                try
                {
                    Conexion cx = new Conexion();
                    using (SqlConnection con = cx.Conectar())
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.ExecuteNonQuery();
                    }
                    cx.Desconectar();

                    MessageBox.Show("Precarga completada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresca combos/grids si este form los tiene
                    try
                    {
                        var metodo = this.GetType().GetMethod("CargarTorneos", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                        if (metodo != null) metodo.Invoke(this, null);
                    }
                    catch { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la precarga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /*-----------------------------------------------------------------------------*/
    }
}
