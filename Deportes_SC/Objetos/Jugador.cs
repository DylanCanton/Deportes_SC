using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class Jugador
    {
        int identificador;
        string cédula;
        string nombre;
        string genero;
        string posicion;
        int equipo; // Aca se tienen que cargar los equipos creados y se hace la relacion con la tabla Jugador/Equipo 
        string nombreEquipo;
        DateTime fechaNacimiento;

        public Jugador ()
        {

        }

        public Jugador(int identificador, string cédula, string nombre, string genero, string posicion, int equipo, string nombreEquipo, DateTime fechaNacimiento)
        {
            this.identificador = identificador;
            this.cédula = cédula;
            this.nombre = nombre;
            this.genero = genero;
            this.posicion = posicion;
            this.equipo = equipo;
            this.nombreEquipo = nombreEquipo;
            this.fechaNacimiento = fechaNacimiento;
            
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public string Cédula { get => cédula; set => cédula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int Equipo { get => equipo; set => equipo = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        //Validar la edad cumplida al momento de hacer el registro
        //sea menor o igual a la categoría etaria del torneo
    }
}
