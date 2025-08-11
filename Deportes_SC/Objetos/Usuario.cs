using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes_SC.Objetos
{
    public class Usuario
    {
        
        int id;
        string nusuario;
        string contrasenna;
        string rol; // Administrador // SubAdministrador // Arbitro //
        int estado;

        public Usuario ()
        {

        }

        public Usuario(int id, string nusuario, string contrasenna, string rol, int estado)
        {
            this.id = id;
            this.nusuario = nusuario;
            this.contrasenna = contrasenna;
            this.rol = rol;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nusuario { get => nusuario; set => nusuario = value; }
        public string Contrasenna { get => contrasenna; set => contrasenna = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
