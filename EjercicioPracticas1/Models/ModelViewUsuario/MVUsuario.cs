using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPracticas1.Models
{
    public class MVUsuario
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Activo { get; set; }

    }
}