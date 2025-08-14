using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class EmparejamientosGenerador
    {
        public static List<Partido> Generar(int idTorneo, List<int> equipoIds, bool idaYVuelta)
        {
            var lista = new List<Partido>();
            if (equipoIds == null || equipoIds.Count < 2) return lista;

            for (int i = 0; i < equipoIds.Count; i++)
            {
                for (int j = i + 1; j < equipoIds.Count; j++)
                {
                    int casa = equipoIds[i];
                    int visita = equipoIds[j];

                    lista.Add(NuevoPartidoBasico(idTorneo, casa, visita));

                    if (idaYVuelta)
                        lista.Add(NuevoPartidoBasico(idTorneo, visita, casa));
                }
            }
            return lista;
        }

        private static Partido NuevoPartidoBasico(int idTorneo, int casa, int visita)
        {
            return new Partido
            {
                Identificador = 0,     // lo asignará la BD si luego decides guardar
                Torneo = idTorneo,
                Jornada = 0,           // sin uso aquí
                FechaHora = DateTime.MinValue, // placeholder, NO se usa
                EquipoCasa = casa,
                EquipoVisita = visita,
                GolesCasa = 0,
                GolesVisita = 0,
                Fase = "REGULAR",
                Estado = "PENDIENTE",
                NombreEquipoCasa = null,
                NombreEquipoVisita = null
            };
        }
    }
}
