using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class Partido
    {
        int identificador;
        int torneo;
        int jornada;
        DateTime fechaHora;
        int equipoCasa;
        int equipoVisita;
        int golesCasa;
        int golesVisita;
        string fase;
        string estado;
        string nombreEquipoCasa; // para mostrar en DataGridView
        string nombreEquipoVisita; // II

        public Partido()
        {
        }

        public Partido(int identificador, int torneo, int jornada, DateTime fechaHora, int equipoCasa, int equipoVisita,
                       int golesCasa, int golesVisita, string fase, string estado,
                       string nombreEquipoCasa, string nombreEquipoVisita)
        {
            this.identificador = identificador;
            this.torneo = torneo;
            this.jornada = jornada;
            this.fechaHora = fechaHora;
            this.equipoCasa = equipoCasa;
            this.equipoVisita = equipoVisita;
            this.golesCasa = golesCasa;
            this.golesVisita = golesVisita;
            this.fase = fase;
            this.estado = estado;
            this.nombreEquipoCasa = nombreEquipoCasa;
            this.nombreEquipoVisita = nombreEquipoVisita;
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public int Torneo { get => torneo; set => torneo = value; }
        public int Jornada { get => jornada; set => jornada = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public int EquipoCasa { get => equipoCasa; set => equipoCasa = value; }
        public int EquipoVisita { get => equipoVisita; set => equipoVisita = value; }
        public int GolesCasa { get => golesCasa; set => golesCasa = value; }
        public int GolesVisita { get => golesVisita; set => golesVisita = value; }
        public string Fase { get => fase; set => fase = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreEquipoCasa { get => nombreEquipoCasa; set => nombreEquipoCasa = value; }
        public string NombreEquipoVisita { get => nombreEquipoVisita; set => nombreEquipoVisita = value; }
    }
}

