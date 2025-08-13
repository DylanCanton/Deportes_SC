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
        // Asignacion de botones para abrir el form que corresponde :)
        private void btn_Torneos_Click(object sender, EventArgs e)
        {
            FrmTorneos frmTorneos = new FrmTorneos();
            frmTorneos.Show();
            this.Hide();
        }

        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.Show();
            this.Hide();
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            FrmJugadores frmJugadores = new FrmJugadores();
            frmJugadores.Show();
            this.Hide();
        }

        private void btn_Partidos_Click(object sender, EventArgs e)
        {
            FrmPartidos frmPartidos = new FrmPartidos();
            frmPartidos.Show();
            this.Hide();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
            this.Hide();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
            this.Hide();
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

        /*-----------------------------------------------------------------------------*/

    }
}
