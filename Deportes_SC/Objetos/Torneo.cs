using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class Torneo
    {
        int identificador;
        string nombre;
        string categoriaEtaria;
        string categoriaGenero;
        DateTime año;

        public Torneo()
        {

        }

        public Torneo(int identificador, string nombre, string categoriaEtaria, string categoriaGenero, DateTime año)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.categoriaEtaria = categoriaEtaria;
            this.categoriaGenero = categoriaGenero;
            this.año = año;
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CategoriaEtaria { get => categoriaEtaria; set => categoriaEtaria = value; }
        public string CategoriaGenero { get => categoriaGenero; set => categoriaGenero = value; }
        public DateTime Año { get => año; set => año = value; }
    }
}
