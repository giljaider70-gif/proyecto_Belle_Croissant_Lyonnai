using System;
using System.Collections.Generic;
using System.Text;

namespace Mis_Clases
{
    public class Usuario
    {
       public int idUsuario { get; set; }

       public string? preguntaSeguridad { get; set; }

        public string? metodoEntrega { get; set; }

        public string? nombre { get; set; }

        public string? apellido { get; set; }

        public string? Telefono { get; set; }

        public string? Correo { get; set; }

        public string? contrasena { get; set; }

        public byte[]? FotoPerfil { get; set; }

        public string? respuestaSeguridad { get; set; }

        public bool SuscripcionListaCorreo { get; set; }

        public string? rol { get; set; }



    }
}
