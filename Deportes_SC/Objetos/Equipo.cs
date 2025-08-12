using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class Equipo
    {
        // Tomar en cuenta un max de 12 jugadores por equipo
        int identificador;
        string nombre;
        string lugarOrigen;
        string encargado;
        string telefono;
        int torneo;
        string nombreTorneo; // solo para mostrar el nombre el el datagridview
                             // y que no se vea feo jeje

        public Equipo()
        {

        }

        public Equipo(int identificador, string nombre, string lugarOrigen, string encargado, string telefono, int torneo, string nombreTorneo)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.lugarOrigen = lugarOrigen;
            this.encargado = encargado;
            this.telefono = telefono;
            this.torneo = torneo;
            this.nombreTorneo = nombreTorneo;
        }


        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Torneo { get => torneo; set => torneo = value; }
        public string NombreTorneo {  get => nombreTorneo; set => nombreTorneo = value;}
    }
}
