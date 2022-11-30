using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }

        public Usuario(long Id, string Nombre, string Apellido, string NombreUsuario, string Contrasenia, string Email)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.NombreUsuario = NombreUsuario;
            this.Contrasenia = Contrasenia;
            this.Email = Email;

        }
        public Usuario() { }


      

    }

}
